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
- I created repository classes that will contain all data access operations relating to Orders, Customers, and Products.
  
### Transfer data access operations:
- I transferred all data access operations from the Devices controller to the Orders Repository class,
- from the Zones controller to the Customers Repository class,
- and from the Categories controller to the Products Repository class.

### Implement repository classes:
- I implemented the use of the Customer repository class in the Orders controller in place of data access operations that have been transferred to the repository class.
- I then implemented the use of the Products repository class in the Orderscontroller in place of data access operations that have been transferred to the repository class.


# Project Close-out
### Security:
- I ensured that no credentials were stored on GitHub.
  
### Web API Cloud Hosting:
- Created an App Service.
- Finally, I published my App to the service hosted on Azure and ensured that the App was secure and accessible

# Project 3 GitHub Link
- [ ] https://github.com/29568706Fistoz/CMPG-323-Project-3---29568706

# References
- Repository pattern C# (2020) YouTube. Available at: https://www.youtube.com/watch?v=yu9EDcX-NMI (Accessed: 21 September 2023).
- Repository pattern in ASP Net core (2019) YouTube. Available at: https://www.youtube.com/watch?v=qJmEI2LtXIY (Accessed: 21 September 2023).
- Karayiannis, C. (2019) Web-based projects that rock the class [Preprint]. doi:10.1007/978-1-4842-4463-0.
- Mezei, R.A. (2023) ‘Introduction’, Introduction to the Development of Web Applications Using ASP .Net (Core) MVC, pp. 1–3. doi:10.1007/978-3-031-30626-6_1.
- ASP.NET core MVC 2022 - 7. dependency injection + repository pattern (2022) YouTube. Available at: https://www.youtube.com/watch?v=o3258sYHhng (Accessed: 21 September 2023). 
