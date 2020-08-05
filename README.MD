# Hair Salon

#### A quick website for Claire to help make their job easier

#### By Cody Fritz\_

[HairSalon-Solution](https://github.com/Zentraxius/week9proj)

## Description

A website specially made for Eau Claire's Salon, to help manage their Stylists and their Clients. 

## Setup/Installation Requirements

- To clone this content, copy the url provided by the 'clone or download' button in GitHub
- In command line use the command 'git clone https://github.com/Zentraxius/week9proj'
- Open the program in a code editor (Using VisualStudioCode for reference)
- You will need [.NET](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program
- Then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
- Type dotnet build in the command line to compile the code
- Create a .gitignore file and store the bin and obj folders in .gitignore
- Type dotnet run in the command line to run the program, ensuring you are in the hairsalon.solution/HairSalon directory

- Run `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0` &
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
  in the terminal
- Add a file called `appsetting.json` in the HairSalon directory.
- In `appsetting.json` add ![appsetting.json](Assets/setup.png)
- Fill in your `server`, `port`,`database`,`uid`, and `pwd`

# Database Instructions

DROP DATABASE IF EXISTS `FirstName_LastName`;
CREATE DATABASE `FirstName_LastName`;

USE `FirstName_LastName`;

CREATE TABLE `Clients` (
`ClientId` int(11) NOT NULL AUTO_INCREMENT,
`Description` varchar(255) DEFAULT NULL,
`StylistId` int(11) NOT NULL AUTO_INCREMENT,
PRIMARY KEY (`ClientId`)
CONSTRAINT `FK_Clients_Stylists_StylistId` FOREIGN KEY (`StylistId`) REFERENCES `Stylists` (`StylistId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Stylists` (
`StylistId` int(11) NOT NULL AUTO_INCREMENT,
`Description` varchar(255) DEFAULT NULL,
PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

## Importing the provided Database

0. These instructions are assuming you have already downloaded the project and can open it in a proper editor such as VisualStudioCode
1. Copy the file cody_fritz.sql from the hairsalon.solution/HairSalon/cody_fritz.sql location
2. Place in easily accessible folder of your choice, in this example we will use desktop
3. Open a database manager, in this case we will use MySql Workbench
4. From the "Navigator" tab, and the "Administration" sub-tab, we will click on Data Import/Restore
5. Select Import from Self-Contained-File and navigate to the desktop, select the file cody_fritz.sql.
6. Select Start Import.

## Specs

| Behavior       | Input                           | Output                                      |
| -------------- | ------------------------------- | ------------------------------------------- |
| Hire a Stylist | User selects to add new stylist | New stylist is added and updated to website |
| Add a client   | User adds a client to a stylist | Website reflects client for stylist         |

## Known Bugs

_No known bugs_

## Support and contact details

Cody Fritz <clanalia55@gmail.com>\_

## Technologies Used

_The Technologies used in the making of this software was Chrome browser, Visual Studio editor, Windows 10, C#, .Net_

### License

Copyright (c) 2020 **Cody Fritz\_**

MIT License
