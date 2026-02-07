# Countries Microservice CRUD Api
## Assignment 1 - Gabriel Siewert
Student Number: 8832384
---
## Description
This mircoservice provides a small CRUD database for storing county and population information. CURD operations include GetAll, GetById, Create, Update, and Delete.
## Domain Model Description
Includes the nessasary ID for a unique identifier, country name which is required, the contient the country resides in (required), the current population of the country as an integer, and the countries capital city name (required).
## How to run
Clone the repo (or unzip the folder) <br>
Ensure Nuget packages are installed with the command ``` dotnet restore ``` <br>
Update the database with ``` dotnet ef database update ``` <br>
and finally run with ``` dotnet run ```
