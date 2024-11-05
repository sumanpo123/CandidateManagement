# Candidate Management API


# Project Overview
This project is a RESTful API for managing candidate information. 
The API allows you to create or update candidate profiles using their email as a unique identifier.
The application is designed to be scalable and can potentially handle thousands of candidate records in the future.

# Features
 - Add or update candidate information
 - Data validation using FluentValidation
 - Unit testing for validation logic
 - Future potential for database migration
 - Self-deployable with no additional setup required

# Requirements
 - .NET SDK (version 8.1 or higher)
 - Visual Studio or any compatible IDE

# Installation
Clone the repository:


# git clone 
https://github.com/sumanpo123/CandidateManagement.git


# Run the application:

- Open the solution in Visual Studio.
- Set the project as a startup project.
- Run the application using Ctrl + F5 or by clicking on the "Start" button.

# API Endpoints
POST /api/candidates
Request Body:
json

{
  "firstName": "Suman",
  "lastName": "Pokharel",
  "phone": "+977-984932",
  "email": "sum3pok@gmail.com",
  "callTime": "9AM-11AM",
  "linkedinUrl": "https://www.linkedin.com/in/suman-pokharel-127140131/",
  "githubUrl": "https://github.com/sumanpo123/CandidateManagement.git",
  "comment": "Looking for a software engineer position."
}
  - **Description**: Adds or updates candidate information.

### GET /api/candidates/{email}
   Parameters:
  - `email`: sum3pok@gmail.com.

  - **Description**: Retrieves a candidate's information based on their email address.



# Unit Tests
To run the unit tests:

 - Open the solution in Visual Studio.
 - Go to the Test Explorer (Test > Test Explorer).
 - Run the tests to validate the functionality of the application.

# Improvements and Assumptions

# Improvements:

 - Enhance caching strategies for improved performance.
 - Implement a more sophisticated architecture (e.g., service layer).
 - Increase unit test coverage for all features.

# Assumptions:

- The API will eventually connect to a SQL database.
- The project is expected to grow in complexity as more features are added.

# Time Spent
- Total time spent on this project: 5-6 hours 
