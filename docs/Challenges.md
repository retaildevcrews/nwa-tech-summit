# Challenges

## 1 - Build server / working environment

There are many ways to run the Azure, Docker and Kubernetes CLIs. For this lab, we are going to use Azure Shell to create an Ubuntu "build server". We will then SSH into the build server and run the lab from the build server. This avoids the issues you run into when trying install everything locally and ensures that everyone is starting from a known status (DevOps). 

- Challenge
  - Set up your team's working environment and build server
  - Ensure everyone on your team has access to your Azure subscription
  - Fork this repo to your build server

- Success Criteria
  - Your team must be able to SSH into the Ubuntu build server
  - az account list -o table | grep True should list subscription  
  - docker -v should show version greater than 19

- Resources
  - Documentation: [Manage access to Azure resources using RBAC and the Azure Portal](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal)
  - Documentation: [Create VM with the Azure CLI](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/quick-create-cli)
  - Docker [walkthrough](https://github.com/4-co/aks-quickstart/blob/master/docker.md)
  - Github: [aks-quickstart](https://github.com/4-co/aks-quickstart)
  - Documentation: [Azure Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/quickstart)
  - Azure Marketplace: [Ubuntu 18.04 LTS](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/Canonical.UbuntuServer1804LTS?tab=Overview)
  - Documentation: [Linux VMs in Azure](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/)

## 2 - Load IMDb Data

Before building your app, you first need to create the database to support it.  The app provides a service designed to be queried for information about movies, actors, and their associated genres.  Because we want a highly responsive and available app, we chose Cosmos DB as our database service.  The data used for this challenge comes from [IMDb](https://www.imdb.com/interfaces/).

The objective of this challenge is to get you started with your own instance of Cosmos DB populated with the IMDb data and to familiarize yourself with queries in Cosmos DB.

- Challenge
  - Follow the guidance in the readme file in the [imdb folder](../imdb) of this repo to create a Cosmos DB server (SQL API), a database, and a collection and then load the IMDb data.
  - We have provided the code to import the data to Cosmos DB in interest of time.  However, take some time to look over the imdb-import code in the repo.
    - Do you understand what it is doing?
  - Now your Cosmos DB instance should be up and running.
    - Take some time to explore the data in the collection and execute a few queries to get used to the language.
    - Try setting up a Cosmos Notebook and querying your data from there.

- Success Criteria
  - Your team must show your coach a populated Cosmos DB collection and execute a query from either the Azure Portal or a Cosmos Notebook.
  - Explain the reasoning behind the design of the documents and the database.

- References
  - [Azure Cosmos DB](https://docs.microsoft.com/en-us/azure/cosmos-db/introduction)
  - [Cosmos DB Query Cheat Sheet](https://docs.microsoft.com/en-us/azure/cosmos-db/query-cheat-sheet)
  - [Cosmos Notebooks](https://docs.microsoft.com/en-us/azure/cosmos-db/enable-notebooks)

## 3 - Security is Key

When working with applications in the cloud, you need to securely store and access keys, passwords, certificates, and other app secrets.  In this lab, we will be setting up Azure Key Vault to store secrets about the Cosmos DB server created in the previous lab.

- Challenge
  - Create an Azure Key Vault in a new resource group and add the following secrets:
    - CosmosUrl
    - CosmosKey (readonly)
    - CosmosDatabase (name of database)
    - CosmosCollection (name of collection)

- Success Criteria
  - Your team successfully created an Azure Key Vault deployed to a new resource group.
  - Your team added the four Cosmos DB secrets listed above to the Key Vault.

- References
  - [Create and manage Azure Key Vault using Azure CLI](https://docs.microsoft.com/en-us/azure/key-vault/key-vault-manage-with-cli2)

## 4 - But First, Containers

Containers have been adopted as a great way to alleviate portability issues. They form the core of this workshop and underpin everything you'll be exploring as you progress through the challenges.

The objective of this challenge is to ensure you understand the very basics of containers, can work with them on a build server (or locally).

- Challenge
  - You've been tasked with improving the local development experience for new developers by using Docker to simplify the building, testing, and running of the application. Some of the work has been done for you, but it was during a time when teams were split between operations and development, leaving the code split between multiple codebases.

- Building and Testing
  - Your first challenge is to verify that the application still works. In order to do this, you will need to build and run the container.
  - To build the application, use the [source code](../bluebell) and [Dockerfile](https://docs.docker.com/engine/reference/builder/).

- Success Criteria
  - Your team  must show your coach a running bluebell container on the build server. Verify that your container is serving content via HTTP. Explain your setup to your coach and how it could be used for development and testing.

- References
  - Docker
    - [Getting Started with Docker](https://docs.docker.com/get-started/)
    - [Docker Networking](https://docs.docker.com/v17.09/engine/userguide/networking)
    - [Dockerfile reference](https://docs.docker.com/engine/reference/builder/)
    - [Docker CLI reference](https://docs.docker.com/engine/reference/commandline/cli/)

## 5 - Setup ACR

Containers are great, but how do we use them for deployment?

- Challenge
  - Building and Pushing Images
  - Now that you are sure the application works, the team must ensure that all of the components are built as Docker images and pushed to the team's Azure Container Registry (ACR).

- Success Criteria
  - Your team  must have built images and pushed them to the team's ACR. Share your understanding of how each of the images were built and pushed to the registry with your coach.

- References
  - [Azure CLI reference](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli)
  - [Azure Container Registry](https://docs.microsoft.com/en-us/azure/container-registry/)

## 6 - Ready for Orchestration

Containers are extremely useful on their own, but their flexibility and potential is multiplied when deployed to an orchestrator. Some of the advantages of deploying your containers to an orchestrator include:

- Deployment reliability
- Scaling on demand
- Better resource utilization and application density

- Challenge
  - At this point, you've built the images for the components of your application and made those images available in your private ACR. Your team's goal in this challenge is to deploy your application to a Azure Kubernetes Service (AKS) cluster in your Azure subscription.
  - Focus on making sure your containers are all up and can communicate and reach the necessary Azure services.

- Success Criteria
  - Your team  successfully created an AKS cluster in Azure
  - Your team  must demonstrate that at least one pod for bluebell application is running
  - Your team must demonstrate that the components in your cluster can connect to other components or resources.
  - The bluebell UI is reachable.

- References
  - Kubernetes
    - [Kubernetes core concepts](https://docs.microsoft.com/en-us/azure/aks/concepts-clusters-workloads) 
    - [Kubernetes objects](https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/) 
    - [Kubernetes secrets](https://kubernetes.io/docs/concepts/configuration/secret/) 
    - [Kubernetes service networking](https://kubernetes.io/docs/concepts/services-networking/) 
    - [Kubernetes DNS for services and pods](https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/) 
    - [Kubernetes Port Forwarding](https://kubernetes.io/docs/tasks/access-application-cluster/port-forward-access-application-cluster/) 
    - [Kubernetes External Load Balancers](https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/) 
    - [Kubectl overview](https://kubernetes.io/docs/user-guide/kubectl-overview/) 
  - Azure Kubernetes Service (AKS)
    - [Deploy an AKS cluster using Azure CLI](https://docs.microsoft.com/en-us/azure/aks/kubernetes-walkthrough) 
    - [Azure CLI: az aks create](https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest#az-aks-create) 
  - Azure Container Registry (ACR)
    - [Authenticate with ACR from AKS](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-auth-aks) 
  - Azure
    - [Azure CLI reference](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli) 
    - [Resource naming conventions](https://docs.microsoft.com/en-us/azure/architecture/best-practices/naming-conventions)

## 7 - Deploy highly available

## 8 - Wait, what's happening
