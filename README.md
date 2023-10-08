# Search Results WebScraper Project

## Intro

The spec for the project can be found here: [WebScraper_App/infotrack_task.pdf](https://github.com/nabzali/WebScraper_App/blob/main/infotrack_task.pdf)

For this project I chose to create an Angular app to go along with the ASP.NET Web API. 

I compiled a gallery of screenshots to show things like the application running in Google Chrome. 
To view these, kindly see [WebScraper_App
/Screenshots](https://github.com/nabzali/WebScraper_App/tree/main/Screenshots).

The Angular front-end contains two views nested inside the root component. Navigate between them using the two tabs at the top of the UI.

1. **Search View**: Allows users to perform searches and retrieve search results.
2. **History View**: Allows users to view search history data.

## Design/Architecture Choices

[Add a brief description of the design and architecture choices you made for your project here.]

## API Endpoints

Base URL: `https://localhost:44380/`

**Get search history to populate history data table**
```http
GET /api/history
```
**Perform search to get search result and store the data**
```http
POST /api/search
```
## Database Layer

## Instructions

[Include instructions on how to set up and run your project locally if applicable.]

## Contact

[Provide contact information or a way for users to get in touch with you if they have questions or feedback about the project.]

