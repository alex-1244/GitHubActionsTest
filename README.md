# GitHubActionsTest

See https://docs.microsoft.com/en-us/azure/container-instances/container-instances-github-action
for step-by step on how to configure azure.

some ready to go commands:

$groupId=$(az group show `
  --name playground `
  --query id --output tsv)

az ad sp create-for-rbac `
  --scope $groupId `
  --role Contributor `
  --sdk-auth

$registryId=$(az acr show `
  --name alexplaygroundcontainerregistry  `
  --query id --output tsv)
  
  
az role assignment create `
  --assignee adc7a492-fab6-4337-af93-6ea90320f5fd `
  --scope $registryId `
  --role AcrPush
