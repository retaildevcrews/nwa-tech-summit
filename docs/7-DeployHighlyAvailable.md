# 7 - Deploy a Highly Available Application

As mentioned in Challenge #6 some of the advantages of deploying your containers to an orchestrator include:

- Deployment reliability
- Scaling on demand
- Better resource utilization and application density

## Challenge

- At this point, you've built the images for the components of your application and made those images available in your private ACR. The team has deployed a single pod running the application and the site is up and available. Your team's goal in this challenge is to deploy your application in a highly available manner in cluster using replicasets. Maintain 3 replicas of the same deployment.
- Rebuild the container with a tag of v2 and push to the container registery. update your kubernetes deployment to create a rolling upgrade of the application to the new version.
- Institute a rollback of your deployment and verify that the application is back to the proper version.

## Success Criteria

- Your team successfully created a multi-replica deployment of the application
- Your team must demonstrate that all of the replicas are receiving traffic (Hint you may have to use different clients to test)
- Your team must demonstrate that the application was updated to a new version and can be rolled-back.
- The Helium UI (swagger) is reachable.

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
