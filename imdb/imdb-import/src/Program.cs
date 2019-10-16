using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using System.Threading;
using Microsoft.Azure.Documents;

namespace imdb_import
{
    class Program
    {
        static int count = 0;
        static DocumentClient client;
        static Uri collectionLink;
        static object rowLock = new object();

        static async Task Main(string[] args)
        {
            // This loader uses the single document upsert API for simplicity
            // Peak throughput is about 20 documents / sec
            // While the loader uses multiple concurrent tasks to speed up the loading,
            // the bulk load APIs should be used for large loads

            // make sure the args were passed in
            if (args.Length != 4)
            {
                Usage();
                Environment.Exit(-1);
            }

            Console.WriteLine("Reading Data\n");

            // get the Cosmos values from args[]
            string cosmosUrl = string.Format("https://{0}.documents.azure.com:443/", args[0].Trim().ToLower());
            string cosmosKey = args[1].Trim();
            string cosmosDatabase = args[2].Trim();
            string cosmosCollection = args[3].Trim();

            // open the Cosmos client
            client = new DocumentClient(new Uri(cosmosUrl), cosmosKey);
            await client.OpenAsync();

            // create the collection link
            collectionLink = UriFactory.CreateDocumentCollectionUri(cosmosDatabase, cosmosCollection);

            // load actors from the json files
            // actors is the largest file so we load actors first
            List<dynamic> Actors = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(@"data/actors.json"));

            Console.WriteLine("Importing Data ...");

            // worker threads
            List<Task> tasks = new List<Task>();

            // set the batch size
            // you want to limit the number of concurrent load tasks to < 10 with a 400 RU collection
            const int batchSize = 100;
            int max = Actors.Count / batchSize;

            // load actors batchSize documents at a time
            for (int i = 0; i < max; i++)
            {
                tasks.Add(LoadData(Actors, i * batchSize, batchSize));
            }

            // load remaining actors
            if (Actors.Count > max * batchSize)
            {
                tasks.Add(LoadData(Actors, max * batchSize, Actors.Count - max * batchSize));
            }

            // load movies
            List<dynamic> Movies = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(@"data/movies.json"));
            tasks.Add(LoadData(Movies, 0, Movies.Count));

            // load genres
            List<dynamic> Genres = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(@"data/genres.json"));
            tasks.Add(LoadData(Genres, 0, Genres.Count));

            // wait for tasks to finish
            Task.WaitAll(tasks.ToArray());

            // done
            Console.WriteLine("Documents Loaded: {0}\n\nImport Complete", count);
        }

        static async Task LoadData(List<dynamic> list, int start, int length)
        {
            // load data worker

            // set the index to load a range of a collection
            int max = start + length;
            int i = start;

            while (i < max)
            {
                try
                {
                    // this will throw an exception if we exceed RUs
                    await client.UpsertDocumentAsync(collectionLink, list[i]);
                    i++;
                    IncrementRowCount();
                }
                catch (DocumentClientException dce)
                {
                    // catch the CosmosDB RU exceeded exception and retry

                    Thread.Sleep(dce.RetryAfter);
                }

                catch (Exception ex)
                {
                    // log and exit

                    Console.WriteLine(ex);
                    Environment.Exit(-1);
                }
            }
        }

        static void IncrementRowCount()
        {
            // lock the counter to increment and print progress
            lock (rowLock)
            {
                count++;

                // update progress
                if (count % 50 == 0)
                {
                    Console.WriteLine("Documents Loaded: {0}", count);
                }
            }
        }

        static void Usage()
        {
            Console.WriteLine("Usage: imdb-import Name Key Database Collection");
        }
    }
}
