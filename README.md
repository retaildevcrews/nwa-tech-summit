# Agenda

## Presentation: [Azure Overview](./docs/slides/intro_to_azure.pptx)

## Challenge 1: [Build server / working environment](./docs/1-BuildServer.md)

There are many ways to run Azure, Docker and Kubernetes CLIs.  For this challenge, we are going to use Azure Shell to create an Ubuntu "build server".  We will then SSH into the build server and run the remaining challenges from the build server.  This avoids the issues you run into when trying install everything locally and ensures that everyone is starting from a known status (DevOps).

## Presentation: [Intro to CosmosDB](./docs/slides/intro_to_cosmosdb.pptx)

## Challenge 2: [Load IMDB Data](./docs/2-IMDb.md)

Before building your app, you first need to create the database to support it.  The app provides a service designed to be queried for information about movies, actors, and their associated genres.  Because we want a highly responsive and available app, we chose Cosmos DB as our database service.  The data used for this challenge comes from [IMDb](https://www.imdb.com/interfaces/).

The objective of this challenge is to get you started with your own instance of Cosmos DB populated with the IMDb data and to familiarize yourself with queries in Cosmos DB.

## Challenge 3: [Security Is Key](./docs/3-SecurityIsKey.md)

When working with applications in the cloud, you need to securely store and access keys, passwords, certificates, and other app secrets.  In this challenge, we will be setting up Azure Key Vault to store secrets about the Cosmos DB server created in the previous challenge.

## Presentation: [Intro to Containers and AKS](./docs/slides/intro_to_containers_kubernetes.pptx)

## Challenge 4: [But First, Containers](./docs/4-ButFirstContainers.md)

Containers have been adopted as a great way to alleviate portability issues. They form the core of this workshop and underpin everything you'll be exploring as you progress through the challenges.

The objective of this challenge is to ensure you understand the very basics of containers, can work with them on a build server (or locally).

## Challenge 5: [Setup ACR](./docs/5-SetupACR.md)

Containers are great, but how do we use them for deployment?

The objective of this challenge is to ensure you know how to build a Docker image and push it to Azure Container Registry (ACR).

## Challenge 6: [Ready For Orchestration](./docs/6-ReadyForOrchestration.md)

Containers are extremely useful on their own, but their flexibility and potential is multiplied when deployed to an orchestrator.

The objective of this challenge is to deploy your application to a Azure Kubernetes Service (AKS) cluster in your Azure subscription.

## Challenge 7: [Deploy Highly Available](./docs/7-DeployHighlyAvailable.md)

The objective of this challenge is to deploy your application in a highly available manner, commit a rolling update to a new version, and rollback the deployment.

## Challenge 8: [Wait, What's Happening](./docs/8-WaitWhatsHappening.md)

Deploying your applications to a cluster is just the first step for running containers in production, and it's important to think about operations and scenarios around your deployments. It is valuable to have a holistic understanding of your cluster when it comes to ensuring your applications are reliable, available, and tolerant to failures.

## Contributing

This project welcomes contributions and suggestions. Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit [Microsoft Contributor License Agreement](https://cla.opensource.microsoft.com).

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
