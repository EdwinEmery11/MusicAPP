# MusicAPP
MUSIC APPLICATION:
This music application is a web application made for people looking to keep track of their favourite albums and songs. An application that beneficial for any situation you're in, whether that's at the gym trying to reach your goals, or for casual listen thru out your day.
users can add the name of the album they would like to listen to as well as a few extra details; album name, Tracks Genre, and interesting information they would like for the album. They then choose their favourite songs and add them to the album.
Contributors
Edwin Emery
________________________________________
Contents:
1.	Brief
2.	Kanban Board - using Trello
3.	ERD - Database structure
4.	Testing
5.	Continuous Integration
6.	Risk Assessment
7.	Evaluation
________________________________________
Brief
This project objective was to create a CRUD application with different tools, methodologies and technologies.
To comply with the objectives, I used the following technologies:
•	Trello board - containing user stories and tasks that need to be completed to meet the MVPs of this project.
•	A relational database in MySQL containing 2 tables.
•	Functional ASP.NET code that allowed for CRUD operations to be performed in the view.
•	Test analysis.
•	Azure DevOps for Continuous Integration that deploys to an app service.
•	Version control using Git.
•	A comprehensive risk assessment.
These were considered the Minimum Viable Product (MVP) for my project.
________________________________________
Music App Trello board
As show in the image above, I created user stories based on functions the user wanted to do while accessing the web application. A user story is the end goal of the project that's expressed thru the user’s perspective
I also created acceptance criteria to consider the necessary software implementations to meet these requirements.
The rest of the board is divided in to three parts to do and done, in this project you can see that the MVP requirements of the project have been completed
To see the details of this board please use the following link: https://trello.com/b/rsHKaw5S
________________________________________
ERD (Entity Relationship Diagram)
ERD is a structural diagram used for database design. below is the ERD for this project that consists of 2 tables
     

The relationship shown here in the table is a one and only one notation from albums and a zero through many notations to song. One album and only 1 album can 0 or many songs.
   
A view of that relationship in the database (MySQL)
The database consisted of 2 tables an Albums table and a songs table, the album table consisted of; id, name, tracks, an album picture, genre, some general information about the album and when the user created that album, in contrast to the song table which was much more specific on the songs of the album looking at fields such as the artist’s name, track name, if that track was one of their favourite tracks and an albumID as a foreign Key.

