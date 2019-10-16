# NWA Tech Hackfest

# Agenda

## Presentation: Azure overview 

## Pre-Challenge: build server / working environment 

- Create Azure AD accounts for team members 
- Assign build master 
- Create Ubuntu build server VM from the Portal 
- SSH into server and run setup.sh gist 
- az login 

## Presentation: Intro to CosmosDB 

## Challenge: Load IMDB Data 

- Clone IMDB repo onto build server 
- Create CosmosDB server 
- Create collection 
- Run import script 
  - Take a look at import-imdb import code; Do you understand it? 
- Query the database 
  - Check out CosmosDB notebooks 

## Challenge: Security Is Key 

- Manage secrets and certs with Azure Key Vault 
- Create KV 
- Add CosmosDB keys / secret to KV 

## Presentation: Intro to containers & AKS 

## Challenge: But First, Containers 

- Pull bluebell-nwa 
- Build, run bluebell and test 
  - Curl /healthz 
  - Optional: run integration test 

## Challenge: Setup ACR 

- Push images to registry 

## Challenge: Ready For Orchestration 

- Use Azure Kubernetes Service to configure and create a Kubernetes cluster 
  - Confirm Kubectl get nodes 
- Integrate identity with AKS (AAD-pod-identity) 
- Deploy bluebell-nwa container from Challenge 1 to the Kubernetes cluster using appropriate namespaces 
  - Configure yaml w/ env vars 
  - Open aks URL from browser 

## Challenge: Deploy highly available 

- Deploy multi-replica instance of the app 
- Commit rolling update to version 2 of the app 
- Verify that all pods are now running v2 
- Rollback 

## Challenge: Wait, What's Happening? 

- Use Azure Monitor to monitor the health of the AKS cluster 
- Create alerts to detect issues 



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
