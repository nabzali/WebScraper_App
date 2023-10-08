# Search Results WebScraper Project for InfoTrack

## Intro

The spec for the project can be found here: [WebScraper_App/infotrack_task.pdf](https://github.com/nabzali/WebScraper_App/blob/main/infotrack_task.pdf)

I compiled a gallery of screenshots to show things like the application running in Google Chrome. 
To view these, kindly see [WebScraper_App
/Screenshots](https://github.com/nabzali/WebScraper_App/tree/main/Screenshots).

## Instructions
1. Clone this project.
2. In the [directory for the front-end](https://github.com/nabzali/WebScraper_App/tree/main/WebScraper-FrontEnd), run `npm install` followed by `ng serve`. 
3. In the [directory for the back-end](https://github.com/nabzali/WebScraper_App/tree/main/WebScraper-BackEnd/WebScraper-BackEnd), run `dotnet run`.
- The Angular app should spin up on `http://localhost:4200`, whilst the Web API should be hosted on `https://localhost:7033`
- The connection string is stored in the [appsettings.json](https://github.com/nabzali/WebScraper_App/blob/main/WebScraper-BackEnd/WebScraper-BackEnd/appsettings.json) file in the back-end
- And if needed, see the [SQL queries used to create the database schema](https://github.com/nabzali/WebScraper_App/blob/main/WebScraper-BackEnd/WebScraper-BackEnd/SQL%20Scripts/InsertData.sql)

## Design/Architecture Choices

For this project I chose to create an Angular app to go along with the ASP.NET Web API, featuring an MSSQL Express instance to store search history data.

**Front End (Angular)**

URL: `http://localhost:4200/`
The Angular front-end consists of two views nested inside the root component. Navigate between them using the two tabs at the top of the UI.
1. **Search View**: Allows users to perform searches and retrieve search results.
2. **History View**: Allows users to view search history data.

An instance of [applicationService.ts](https://github.com/nabzali/WebScraper_App/blob/main/WebScraper-FrontEnd/src/app/services/applicationService.ts) is injected into each component to perform the relevant API requests.

Two models were also created to represent data. 
- A **searchRequestModel**
- A **searchResponseModel**

**Back-End (ASP.NET Web API)**

Base URL: `https://localhost:7033/`
A controller method to deal with API requests features methods for two endpoints, corresponding to the request from the Search component (POST request) and the history component (GET request).

**Get search history to populate history data table**
```http
GET /api/history
```
**Perform search to get search result and store the data (sent with searchRequestModel body)**
```http
POST /api/search
```

An instance of [ApplicationService.cs](https://github.com/nabzali/WebScraper_App/blob/main/WebScraper-BackEnd/WebScraper-BackEnd/Services/ApplicationService.cs) is injected into the controller to perform the domain functionality (database transactions and performing the search).

Two 'ViewModels' were created to represent the data, corresponding to the ones in the front-end:
- A **SearchRequestViewModel**
- A **SearchResponseViewModel**

But these would be mapped to a **SearchEntity** which stores the result of a search in the database.
Entity Framework Core and Migrations were used to sync my Entity with the database.

