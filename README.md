# High Availability / Disaster Recovery Ready Web App with Azure SQL DB

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fdevkeydet%2FTrafficManagerWebAppSqlDbHaDr%2Fmaster%2FTrafficManagerWebAppSqlDbHaDr-RG%2FTemplates%2FWebSiteSQLDatabase.json)  [![Deploy to Azure Gov](http://azuredeploy.net/AzureGov.png)](https://portal.azure.us/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fdevkeydet%2FTrafficManagerWebAppSqlDbHaDr%2Fmaster%2FTrafficManagerWebAppSqlDbHaDr-RG%2FTemplates%2FWebSiteSQLDatabase.json)  [![Visualize](http://armviz.io/visualizebutton.png)](http://armviz.io/#/?load=https%3A%2F%2Fraw.githubusercontent.com%2Fdevkeydet%2FTrafficManagerWebAppSqlDbHaDr%2Fmaster%2FTrafficManagerWebAppSqlDbHaDr-RG%2FTemplates%2FWebSiteSQLDatabase.json)

## Overview
This is a sample ARM template to deploy a Web App / SQL DB to two regions and configure both Traffic Manager in front of the Web Apps and SQL Geo-Replication for the databases.  It also deploys an ASP.NET Core MVC app from this repo.

![Diagram of architecture](/Diagrams/Diagram.jpg)