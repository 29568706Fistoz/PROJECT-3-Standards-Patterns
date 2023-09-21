## CMPG-323-Project-3---29568706

# EcoPower_Logistics
![ecoPic](https://github.com/29568706Fistoz/CMPG-323-Project-3---29568706/assets/141215973/c8882f53-a128-4c8f-bafd-3c01c50223c1)


# Table of Content
- Project Description
- Overview
- GitHub Administration
- Project Setup
- Design Pattern Implementation
- Project Close-out
- Project Link
- References


# Project Description
#### Project 3: Implementing coding principles and design patterns


# Overview
 In this day and age, there are millions of applications that have been created and are widely used. A developer’s ability to read and understand code is even more important than their ability to write code. As such, I was given an existing ASP.NET Core MVC Web Application that needed to be enhanced and improved. 
As part of this project, I was expected to understand architectural patterns as well as pay specific attention to implementing coding principles and design patterns – aligning with the requirements of the project. 



# GitHub Administration
### Create and Configure GitHub Repository:
- Created a repository named ‘CMPG 323 Project 3 - 29568706
- Created a ReadME.md file that will be used to describe my project and how stakeholders are to use the report that I have developed
  
### Project Progress:
- I ensured that the solution has been committed and pushed to source control throughout the project
- I ensured that the GitHub project was updated iteratively throughout the project to demonstrate how progress was made


# Project Setup
### Access the existing project:
- I Forked the existing GitHub repository.
- I then created a new development branch on my repository to work on.

### Connected the Web App to the data source:
- In the appsettings.json file I added the connection string to my hosted database.



# Design Pattern Implementation
### Created Repository Classes:
- I created repository classes that will contain all data access operations relating to Orders, Customers and Products.
  
### Transfer data access operations:
- I transfered all data access operations from the Devices controller to the Orders Repository class,
- from the Zones controller to the Customers Repository class,
- and from the Categories controller to the Products Repository class.

### Implement repository classes:
- I implemented the use of the Customer repository class in the Orders controller in place of data access operations that have been transferred to the repository class.
- I then implemented the use of the Products repository class in the Orderscontroller in place of data access operations that have been transferred to the repository class.


# Project Close-out
### Security:
- I ensured that no credentials are stored on GitHub.
  
### Web API Cloud Hosting:
- Created an App Service.
- Finally I published my App to the service hosted on Azure and ensured that the App is secure and accessible

# Project 3 GitHub Link
- [ ] 

# References
