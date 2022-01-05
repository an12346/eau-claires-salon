# Eau Claire Salon

#### By: Anna Pittman

#### A web application for a hair salon

## Technologies Used

* _C#_
* _.NET_
* _Entity_
* _MySQL_

## Description

This web application allows hair salon owners to keep track of their stylists and clients. Users can add stylists to their database and see all of the clients that are associated with each stylist.  

## Setup/Installation Requirements

* Clone this repository to your desktop 
* Naviagate to the HairSalon directory 
* Next, compile the code using the command `$ dotnet build` 
* Then, to run the application in a web browser, use the command `$ dotnet run`
* Create a file in the HairSalon directory called appsettings.json

To recreate database:
* Create a file in the HairSalon directory called appsettings.json
* Add this code to the appsettings.json file:
  {
    "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
    }
  }
* Add your password and database to the appsettings.json file
* Open MySQL Workbench and click on the local server
* Click on Administration then select `Data Import/Restore`
* In Import Options select `Import from Self-Contained File` and choose `anna_pittman.sql`
* Choose a name for the database and then click `Start Import` to import the database 



## Known Bugs

* No Known Bugs

## License

[GitHub Repository](https://github.com/an12346/eau-claires-salon)

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Anna Pittman