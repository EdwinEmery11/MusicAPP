MUSIC APPLICATION:
This music application is a web application made for people looking to keep track of their favourite albums and songs. An application that is beneficial for any situation you're in, whether that's at the gym trying to reach your goals, or for casual listen through out your day.
Users can add the name of the album they would like to listen to as well as a few extra details; album name, Tracks Genre, and interesting information they would like for the album. They then choose their favourite songs and add them to the album.
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
1.	Brief
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
2.	Music App Trello board
 
As show in the image above, I created user stories based on functions the user wanted to do while accessing the web application. A user story is the end goal of the project that's expressed thru the user’s perspective
I also created acceptance criteria to consider the necessary software implementations to meet these requirements.
The rest of the board is divided in to two parts to do and done, in this project you can see that the MVP requirements of the project have been completed
To see the details of this board please use the following link: https://trello.com/b/rsHKaw5S
________________________________________
3.	ERD (Entity Relationship Diagram)
ERD is a structural diagram used for database design. below is the ERD for this project that consists of 2 tables:
    

The relationship shown here in the table is a one and only one notation from albums and a zero through many notations to song. One album and only 1 album can have 0 or many songs.
   
A view of that relationship in the database (MySQL)
The database consisted of 2 tables an Albums table and a songs table, the album table consisted of; id, name, tracks, an album picture, genre, some general information about the album and when the user created that album, in contrast to the song table which was much more specific on the songs of the album looking at fields such as the artist’s name, track name, if that track was one of their favourite tracks and an albumID as a foreign Key.
________________________________________

4.	Testing 
After I finished my CRUD web Application, I started to write code for my unit test, with xUnit Test. To check my data is working as intended, I created 7 unit test in total to test the functionality of my controllers which performed the crud application below is the coverage report for both controllers 
AlbumController test coverage :
 

SongController:
 
________________________________________
5.	Continuous Integration
The general workflow of this project starts from the Trello board where I designed my project. I have followed my board to write the code within Visual Studios. Tested the code to catch any errors and to fix them the application was originally supposed to run on azure DevOps, where each time the code is pushed to my repo on Github, Azure DevOps Automatically deploys it instead I’ve settled for a manual deployment on Visual Studios published to my Azure web app.



















________________________________________

6.	Risk Assessment

 	Description	Evaluation	Likelihood	impact level	Responsibility	Response	Control Measures
1	Data breach 	Project does not have a login and log out function and any one can manipulate the data stored in the database. 	high	 High 	 Developer	 Recreate manipulated data 	 Add control functionality to website to provide security for stored data 
2	 Azure instance failure 	 Azure instance failure, would cause the entire application to fail.	 Low 	 High	 Azure 	  Create spare instance	 Have a backup way of deploying the app e.g. using GitHub Actions 
3	 Traffic overload	 The minimum requirements for this server were selected, with higher traffic issue would arise 	 Low 	 High 	Azure/Developer 	 Monitor network traffic and upgrade cloud needs based on server workload 	 Deploy different instances for different areas of the world so users can access the app instance closest to them 
4	 Code deployed with bugs in 	 Code deployed may have errors and provides error codes 	 medium	High  	Developer 	Make sure Version Control is used before pushing to the main branch for deployment  	 Testing must be performed before deployment, and push to main branch must be authorised by project lead
5	 HTTP attack and data breach is possible 	 Connection to the application can potential become unsecure when used on a VM	 medium	 High 	Developer 	Awareness on the app should be used and the user should avoid posting sensitive information 	 An sensitive information the user inputs should be encrypted and stored separately from the host environment 
6	 	 	 	 	 	 	 
							
Known Issues:
They are a Few bugs with the current app:
•	Currently you cannot update a Song, the app will fail
•	Data validation on the app is all so lacking resulting in incorrect information being entered

Future Improvements:
They are many features I would like to add to this app in the future including:
•	The ability to listen to songs 
•	Login and log out functions
•	The ability to preview a song without login
•	The ability to have just a song playlist 



