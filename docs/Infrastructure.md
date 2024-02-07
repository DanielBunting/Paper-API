The infrastructure is based on: 

1 - A Swift application that hosts the app. 
2 - Deployments done to Azure App Service, set to autoscale when over say 50% resources user. 
3 - Make sure we layer the applications so there is a seperate persistence layer. 
4 - The Storage will be done in Azure Cosmos. 
5 - We will set a awagger page to show the endpoints. 