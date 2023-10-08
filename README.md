# Search Results WebScraper Project

## Description

This project is a web scraping application that allows users to search for information using a web interface built with Angular. The project specification can be found [here](link).

Angular was used for building a front-end, communicating with my ASP.NET Web API back-end.

There are two views (components) in the UI that can be navigated to using the tabs at the top.

1. **Search View**: Allows users to perform searches and retrieve search results.
2. **History View**: Allows users to view search history data.

## Design/Architecture Choices

[Add a brief description of the design and architecture choices you made for your project here.]

## API Endpoints

I implemented 2 endpoints in the controller:

Base URL for the API: `https://localhost:44380/`

**Get search history**
```http
GET /api/history
```
**Perform search**
```http
POST /api/search
```

[Add any additional information about your API endpoints here.]

## Database Layer

## Instructions

[Include instructions on how to set up and run your project locally if applicable.]

## Contact

[Provide contact information or a way for users to get in touch with you if they have questions or feedback about the project.]

