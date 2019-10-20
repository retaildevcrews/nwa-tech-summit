# 3 - Security is Key

When working with applications in the cloud, you need to securely store and access keys, passwords, certificates, and other app secrets.  In this challenge, we will be setting up Azure Key Vault to store secrets about the Cosmos DB server created in the previous challenge.

## Challenge

- Create an Azure Key Vault in a new resource group and add the following secrets:
  - CosmosUrl
  - CosmosKey (readonly)
  - CosmosDatabase (name of database)
  - CosmosCollection (name of collection)

## Success Criteria

- Your team successfully created an Azure Key Vault deployed to a new resource group.
- Your team added the four Cosmos DB secrets listed above to the Key Vault.

## References

- [Managed Identity and Key Vault Sample App](https://aka.ms/mikv)
- [Create and manage Azure Key Vault using Azure CLI](https://docs.microsoft.com/en-us/azure/key-vault/key-vault-manage-with-cli2)
