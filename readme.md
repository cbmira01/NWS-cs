## Synopsis

Neighborhood Web Site

This project demonstrates a neighborhood web site constructed in C#

Completed for Code Louisville's Fall 2016 session

## Web site features
- Feature article with image carousel
- Additional main-page articles with images
- Main-page articles each have a independent URL
- Links to on-site or YouTube videos
- Provision for advertising content
- Flattering display of neighborhood association board members
- List of useful neighborhood phone numbers
- Links to archived newsletters
- All display items under content management
- Content management includes default values and validations on many fields
- Searchable Jeopardy database

## Points of interest
- Panel-based styling features equalization and color cycling
- Born responsive to large, medium and small media
- Article images can be optionally hidden on small media
- Resize to small media causes top-bar alteration and panel squashing
- Small and simple initial test database
- Test database is persistent and can be reseeded
- Side project (NWS-Console) to prepare a large JSON database for the main project

# Packages and frameworks
- Developed in Visual Studio 2015 Community Edition
- MVC 5, Entity Framework 6, .NET 4.5
- Styled with Zurb Foundation 5.5.0
- Slick Carousel 1.5.11 for feature image fading
- jQuery 2.2.4
- Modernizr 2.8.3
- NewtonSoft.Json 9.0.1

## To see it in action:
- Install Visual Studio 2015 Community Edition
- Clone or retrieve this Github project into a preferred folder
- Locate and open the NWS-cs solution in Visual Studio
- Re-seed the database:
    - In SQL Server Object Explorer, delete the NWS_cs database (if it exists)
    - If desired, edit seed data in .../NWS-cs/Migrations/Configuration.cs
    - In Package Manager Console, run "update-database"
    - Refresh SQL Server Object Explorer, and note the creation of 
      of the persistent database:
        - SQLSOE/SQL Server/MSSQLLocalDB.../Databases/NWS_cs
- Build and run the project on a preferred web browser
- See .../NWS-cs/Content/Test/... for additional test content


## Comments welcome to Calvin Miracle, cbmira01@gmail.com
