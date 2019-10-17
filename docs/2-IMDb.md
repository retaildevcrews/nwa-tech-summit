# 2 - Load IMDb Data

Before building your app, you first need to create the database to support it.  The app provides a service designed to be queried for information about movies, actors, and their associated genres.  Because we want a highly responsive and available app, we chose Cosmos DB as our database service.  The data used for this challenge comes from [IMDb](https://www.imdb.com/interfaces/).

The objective of this challenge is to get you started with your own instance of Cosmos DB populated with the IMDb data and to familiarize yourself with queries in Cosmos DB.

## Challenge
  - Follow the guidance in the readme file in the [imdb folder](../imdb) of this repo to create a Cosmos DB server (SQL API), a database, and a collection and then load the IMDb data.
  - We have provided the code to import the data to Cosmos DB in interest of time.  However, take some time to look over the imdb-import code in the repo.
    - Do you understand what it is doing?
  - Now your Cosmos DB instance should be up and running.
    - Take some time to explore the data in the collection and execute a few queries to get used to the language.
    - Try setting up a Cosmos Notebook and querying your data from there.

## Success Criteria
  - Your team must show your coach a populated Cosmos DB collection and execute a query from either the Azure Portal or a Cosmos Notebook.
  - Explain the reasoning behind the design of the documents and the database.

## References
  - [Azure Cosmos DB](https://docs.microsoft.com/en-us/azure/cosmos-db/introduction)
  - [Cosmos DB Query Cheat Sheet](https://docs.microsoft.com/en-us/azure/cosmos-db/query-cheat-sheet)
  - [Cosmos Notebooks](https://docs.microsoft.com/en-us/azure/cosmos-db/enable-notebooks)