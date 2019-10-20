# 1 - Build server / working environment

There are many ways to run Azure, Docker and Kubernetes CLIs.  For this challenge, we are going to use Azure Shell to create an Ubuntu "build server".  We will then SSH into the build server and run the remaining challenges from the build server.  This avoids the issues you run into when trying install everything locally and ensures that everyone is starting from a known status (DevOps). 

## Challenge

### Redeem your Azure Pass Promo Code and activate your subscription

- https://www.microsoftazurepass.com/Home/HowTo
- Ensure everyone on your team has access to your Azure subscription

### Setup one build server in your subscription

Setup and use Cloud Shell to run the following commands.

```bash

# clone this repo
git clone https://github.com/4-co/nwa-tech-summit
cd nwa-tech-summit

# create a new resource group
export ACRRG=acr
export AKSLOC=centralus

az group create -n $ACRRG --location $AKSLOC

```

On your local development machine, find or generate your SSH keys.

```bash

# Make sure you're in your home directory
cd ~

# Create an .ssh folder (if it doesnt already exist)
mkdir .ssh
cd .ssh
ll

###### If id_rsa already exists, do NOT run this command!

# Generate the keys
# Hit enter twice to set an empty passphrase
ssh-keygen -t rsa -f ./id_rsa

######

```

Go back to your browser with Azure Cloud Shell.

Click on the "Upload/Download files" button and select the newly generated id_rsa and id_rsa.pub. (You will have to do this once per file)

```bash

# In Azure Cloud Shell, you should see your uploaded keys in the home dir.
cd ~
ll

# Move the keys to the .ssh folder
mv id_rsa id_rsa.pub .ssh/

# Set the right (owner read+write) permissions for the keys
chmod 600 ~/.ssh/id_rsa.pub
chmod 600 ~/.ssh/id_rsa

```

Now we'll use the Azure CLI in Cloud Shell to create a VM accessible via this SSH key.

```bash

# create Docker build VM
az vm create -g $ACRRG \
-n docker \
--size standard_d2s_v3 \
--nsg-rule SSH \
--image UbuntuLTS \
--os-disk-size-gb 128 \
--admin-username aks \
--custom-data setup/docker_install

export DHOST=aks@`az network public-ip show -g $ACRRG -n dockerPublicIP --query [ipAddress] -o tsv`
echo " "
echo $DHOST

```

SSH into the build server

- You can also SSH into the build server from your laptop by using the IP address
- If anyone else on your team wants to SSH into the server, they will need the SSH keys in their .SSH folder

```bash

ssh $DHOST

```

You should now have all of the tools needed for your build server.

## Install VS Code preview with Remote Development support

Optional (but super cool :)

- [VS Code Preview](https://code.visualstudio.com/insiders/)
- [VS Code Remote Development](https://code.visualstudio.com/blogs/2019/05/02/remote-development)

## Success Criteria

- Your team must be able to SSH into the Ubuntu build server
- `az account list -o table | grep True` should list subscription  
- `docker -v` should show version greater than 19

## Resources

- Documentation: [Setup Azure Cloud Shell](https://github.com/4-co/aks-quickstart/blob/master/cloudshell.md)
- Documentation: [Manage access to Azure resources using RBAC and the Azure Portal](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal)
- Documentation: [Create VM with the Azure CLI](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/quick-create-cli)
- Docker [walkthrough](https://github.com/4-co/aks-quickstart/blob/master/docker.md)
- Github: [aks-quickstart](https://github.com/4-co/aks-quickstart)
- Documentation: [Azure Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/quickstart)
- Azure Marketplace: [Ubuntu 18.04 LTS](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/Canonical.UbuntuServer1804LTS?tab=Overview)
- Documentation: [Linux VMs in Azure](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/)