DECLARE @dbname Varchar(50)
select @dbname = 'TrackingSystem'

USE TrackingSystem

BEGIN
	print 'Creating tables' ;

   --##  Start User Information tables

   CREATE TABLE UserInformation(
	userInfoId int IDENTITY(1,1) not  null PRIMARY KEY ,
	fName varchar(50) NOT NULL,
	lName varchar(50) NOT NULL,
	mName varchar(50) NOT NULL,
	birthDate datetime ,
	presentAddress Varchar(MAX),
	permanentAddress Varchar(MAX),
	mobileNumber varchar(20),
	phoneNumber varchar(20),
	email varchar(50))


	CREATE TABLE UserLogin(
	userId int  FOREIGN KEY REFERENCES UserInformation(userInfoId) NOT NULL PRIMARY KEY,
	userName varchar(50) NOT NULL,
	password varchar(50) NOT NULL,
	salt varchar(20) NOT NULL)

	
	
	CREATE TABLE userRoles(
	userRoleId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	description varchar(50) NOT NULL,
	isActive bit NOT NULL
	)

	CREATE TABLE userUserRoles(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	userId int FOREIGN KEY REFERENCES UserInformation(userInfoId) not  null,
	userRoleId int FOREIGN KEY REFERENCES userRoles(userRoleId) not  null
	)
	-- END User Information tables

	-- ## START Menu tables

	CREATE TABLE ProductType(
	productTypeId int IDENTITY(1,1) NOT NULL primary key ,
	description varchar(128) Not null,
	isActive bit NOT NULL
	)

	CREATE TABLE Item(
	itemId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	productTypeId int FOREIGN KEY REFERENCES ProductType(productTypeId) not null,
	itemDescription VARCHAR(128) NOT NULL,
	isAvailable BIT NOT NULL DEFAULT 1,
	price decimal NOT NULL,
	createdBy int FOREIGN KEY REFERENCES UserInformation(userInfoId) not  null,
	createdDate Datetime NOT NULL,
	updatedBy int FOREIGN KEY REFERENCES UserInformation(userInfoId) not  null,
	updatedDate Datetime NOT NULL
	)

	CREATE TABLE TransactionStatus(
	statusId int IDENTITY(1,1) Not null PRIMARY KEY,
	description varchar(50) not null,
	code varchar(20) not null,
	StatusOrder INT NOT NULL
	)

	CREATE TABLE TransactionTable(
	transactionId INT  IDENTITY(1,1) NOT NULL PRIMARY KEY,
	transactionDate DateTime NOT NULL,
	itemID int FOREIGN KEY REFERENCES Item(itemId) not null,
	staff int FOREIGN KEY REFERENCES UserInformation(userInfoId) not  null,
	transactionNumber varchar(50) NOT NULL,
	quantity INT NOT NULL,
	status INT FOREIGN KEY REFERENCES TransactionStatus(statusId) not null

	)
	-- ## END




	print 'Creation of tables done';
End
