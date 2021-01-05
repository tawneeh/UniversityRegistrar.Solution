# _University Registrar_

#### _Many to Many Database Relationship Practice for Epicodus_ 
#### _DATE 01.04.2021_

#### By _**Tawnee Harris, Max Brockbank and David Sterry**_

## Description

This application will allow a user to create and organize University Students and Courses using many to many database relationships.

## Setup/Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode◊

Open by Downloading or Cloning
* Navigate to <https://github.com/tawneeh/UniversityRegistrar.Solution.git>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository

Setup Instructions
* To build your database go to the appsettings.json file and update your Server, Port, UID, and Password as necessary
* Navigate to UniversityRegistrar.Solution/UniversityTracker and type `dotnet ef migrations add <MigrationName>` into the terminal
* Then, type `dotnet ef database update` into the terminal to create your database tables
* Navigate to UniversityRegistrar.Solution/UniversityTracker and type `dotnet restore` into the terminal
* Then, in the same project folder, type `dotnet build` into the terminal followed by `dotnet run`
* Peruse this application at your leisure

## Known Bugs

This application has no known bugs. 

## Support and contact details

Please feel free to reach out to Tawnee anytime at <tawneeh@icloud.com>

Co-authored-by: Max Brockbank <maxbrockbank1999@gmail.com>
Co-authored-by: David Sterry <sterry.david@gmail.com>

## Technologies Used

* C#
* Razor
* Entity Framework Core

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Tawnee Harris, Max Brockbank and David Sterry_**