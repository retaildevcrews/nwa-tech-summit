# 1 - Build server / working environment

There are many ways to run Azure, Docker and Kubernetes CLIs.  For this lab, we are going to use Azure Shell to create an Ubuntu "build server".  We will then SSH into the build server and run the lab from the build server.  This avoids the issues you run into when trying install everything locally and ensures that everyone is starting from a known status (DevOps). 

## Challenge
  - Set up your team's working environment and build server
  - Ensure everyone on your team has access to your Azure subscription
  - Fork this repo to your build server


## Success Criteria
  - Your team must be able to SSH into the Ubuntu build server
  - az account list -o table | grep True should list subscription  
  - docker -v should show version greater than 19

## Resources
  - Documentation: [Manage access to Azure resources using RBAC and the Azure Portal](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal)
  - Documentation: [Create VM with the Azure CLI](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/quick-create-cli)
  - Docker [walkthrough](https://github.com/4-co/aks-quickstart/blob/master/docker.md)
  - Github: [aks-quickstart](https://github.com/4-co/aks-quickstart)
  - Documentation: [Azure Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/quickstart)
  - Azure Marketplace: [Ubuntu 18.04 LTS](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/Canonical.UbuntuServer1804LTS?tab=Overview)
  - Documentation: [Linux VMs in Azure](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/)