Questionable
===

What is this?
--
Questionable is a proof-of-concept application that allows a 
community/group of people to easily ask questions and find 
information on a variety of topics, to help save community
leadership time and effort in fielding frequently asked questions.
It also serves as a simple help desk solution.

It is broken into two main parts, the front-end and an API backend.

Pre-requisites
---
- A MySQL or MariaDB database.


How does it work?
---
 - Create a database on a MySQL/MariaDB database.
 - Create a "DefaultConnection" for ConnectionStrings inside the
    appsettings.json using the MySQL connection string syntax. 
    (You can use http://connectionstrings.com for help.)
 - `$ dotnet run`




2020, Nicholas Barr. http://www.nicholasbarr.net