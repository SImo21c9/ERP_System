﻿CREATE TABLE Person 
(
	PersonID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	PhoneNumber VARCHAR(50),
	Email VARCHAR(255),
	Street VARCHAR(255),
	StreetNumber VARCHAR(50),
	City VARCHAR(255),
	PostCode VARCHAR(20),
	Country VARCHAR(255)
)
CREATE TABLE Customer 
(
	PersonID INT UNIQUE PRIMARY KEY,
	CustomerNumber VARCHAR(16),
	CONSTRAINT FK_personId FOREIGN KEY (PersonID) REFERENCES Person(PersonId) ON DELETE CASCADE
)