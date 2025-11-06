 Premium Calculator — Angular + .NET Core Web API , C#

A full-stack  **Premium Calculator Application** built using  
**.NET Core Web API (C#)** for backend and **Angular 17 (standalone)** for frontend.




##  Overview

The app allows a user (Member) to enter personal and insurance details to calculate their **Monthly Death Premium** based on their occupation and coverage amount.

The calculation uses this formula: Death Premium = (Death Cover Amount * Occupation Rating Factor * Age) / 1000 * 12



**API Example**

POST → /api/premium/calculate

Request Body

{
  "name": "Alice",
  "ageNextBirthday": 35,
  "dateOfBirth": "05/1990",
  "occupation": "Doctor",
  "deathSumInsured": 100000
}


Response

{
  "monthlyPremium": 63000,
  "occupation": "Doctor",
  "factor": 1.5,
  "age": 35
}

**Testing**

Access Swagger UI 

Use Angular form to test real-time premium calculation.

 
