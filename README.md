# Everbridge
CNL Everbridge Technical Challenge

## Introduction
This is a simple solution to an exercise, part of a job interview. It presents a minimalistic website in the form of a blog that is built with Piranha CMS. The blog fetches data using the [NewsAPI](https://newsapi.org/).

NOTE: Code logic is built with `C#`

NOTE v2: Although the given time to solve the problem was 2 hours (and days ago), I am hoping that you will find my work satisfying. The actual time programming took ~2h 17min - while setting up the environment took me an hour and a half (usually done within minutes).

## Prerequisites
- If using Node, download it here: 
[Node](https://nodejs.org/en/download/current/)
Use the commands:
```
dotnet restore
dotnet run
```
- If using Visual Studio, download it here:
[Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
Just build & run the application
- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [This download specifically](https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-aspnetcore-3.1.10-windows-hosting-bundle-installer)

## Functionalities
- The application seems to satisfy most of the requirements. There is a home page, which does not provide any functionality but felt necessary to have. The blog page displays a collection of articles (posts) and the relevant information, such as:
- Title, Author, Date Published, Description, Content, Comments and Image (if available).
- Anyone may post comments on the blog posts provided that all required fields are filled.

## Knows issues
- The very first time you visit `/blog` you will need to refresh the page to get all articles (posts)
- There is a IP Geoocation functionality developed using a free API, but due to limited testing it is commented out. Therefore articles shown are for Great Britan only (top headlines)
- Working on `main` (master) branch and no other branches; pushing many changes at once

## Manager view
- You may navigate to the manager view to see the actual posts there (using admin/password)
- Adding new pages is not recommended

## Author
Hristiyan Anev