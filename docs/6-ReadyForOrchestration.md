# 6 - Ready for Orchestration

Containers are extremely useful on their own, but their flexibility and potential is multiplied when deployed to an orchestrator. Some of the advantages of deploying your containers to an orchestrator include:

- Deployment reliability
- Scaling on demand
- Better resource utilization and application density

## Challenge

- At this point, you've built the images for the components of your application and made those images available in your private ACR. Your team's goal in this challenge is to deploy your application to a Azure Kubernetes Service (AKS) cluster in your Azure subscription.
- To maintain the confidentiality of the CosmosDb connection Keys, Azure Key Vault will be used by the application to retrieve the needed keys. Integrate AAD Pod Itentity into your cluster and enable the application pods to get an identity from Azure.
- Focus on making sure your containers are all up and can communicate and reach the necessary Azure services.

## Success Criteria

- Your team  successfully created an AKS cluster in Azure
- Your team  must demonstrate that at least one pod for bluebell application is running
- Your team must demonstrate that the components in your cluster can connect to other components or resources.
- The bluebell UI is reachable.

## References

### Kubernetes

- [Kubernetes core concepts](https://docs.microsoft.com/en-us/azure/aks/concepts-clusters-workloads)
- [Kubernetes objects](https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/)
- [Kubernetes secrets](https://kubernetes.io/docs/concepts/configuration/secret/)
- [Kubernetes service networking](https://kubernetes.io/docs/concepts/services-networking/)
- [Kubernetes DNS for services and pods](https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/)
- [Kubernetes Port Forwarding](https://kubernetes.io/docs/tasks/access-application-cluster/port-forward-access-application-cluster/)
- [Kubernetes External Load Balancers](https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/)
- [Kubectl overview](https://kubernetes.io/docs/user-guide/kubectl-overview/)

### Azure Kubernetes Service (AKS)

- [Deploy an AKS cluster using Azure CLI](https://docs.microsoft.com/en-us/azure/aks/kubernetes-walkthrough)
- [Azure CLI: az aks create](https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest#az-aks-create)

### Azure Container Registry (ACR)

- [Authenticate with ACR from AKS](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-auth-aks)
  
### Azure

- [Azure CLI reference](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli)
- [Resource naming conventions](https://docs.microsoft.com/en-us/azure/architecture/best-practices/naming-conventions)

### AAD Pod Identity

- [AAD-Pod-Indentity](https://github.com/Azure/aad-pod-identity)
- [AAD-Pod_identity Gist](https://gist.github.com/evillgenius75/d1c5cdcdf602c4ccd57e56ce330f49de)
