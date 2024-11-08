USE TrackingSystem
Go

CREATE PROC CreateOrUpdateUser
@userId int,
@fname varchar(50),
@lname varchar(50),
@mname varchar(20),
@bday dateTime,
@preAdd varchar(200),
@perAdd varchar(200),
@mobile varchar(20),
@phone varchar(20),
@email varchar(50)

as

If(@userId =0)
	BEGIN 
	INSERT INTO UserInformation 
	(fName,lName,mName,birthDate,presentAddress,permanentAddress,mobileNumber,phoneNumber,email)
	values (@fname,@lname,@mname,@bday,@preAdd,@perAdd,@mobile,@phone,@email);
	END
Else
	BEGIN

	UPDATE UserInformation SET 
	fName =@fname,
	lName=@lname ,
	mName=@mname,
	birthDate=@bday,
	presentAddress = @preAdd,
	permanentAddress = @perAdd,
	mobileNumber=@mobile,
	phoneNumber = @phone,
	email = @email
	WHERE userInfoId = @userId;
	END

SELECT * FROM UserInformation UI
	where CONCAT(UI.fName,UI.lName,UI.mName,UI.email) = CONCAT(@fname,@lname,@mname,@email);
GO

CREATE PROC CREATEORUPDATEUSERLOGIN
@userId int,
@username varchar(max),
@password varchar(max),
@salt varchar(50)

as

DECLARE @numn  int

set @numn = (select COUNT(*) from UserLogin where UserLogin.userId = @userId)

IF (@numn >0)
	BEGIN
		UPDATE UserLogin SET
		UserLogin.password = @password,
		UserLogin.userName = @username
		WHERE UserLogin.userId = @userId
	END
ELSE
	BEGIN 
		INSERT INTO  UserLogin(userId,userName,password,salt) 
		VALUES (@userId,@username,@password,@salt)
	END

SELECT * FROM UserLogin WHERE UserLogin.userId = @userId

GO

CREATE PROC GetAllUser
@strng varchar(50)

as
IF @strng = ''
BEGIN
	SELECT * FROM UserInformation
END
ELSE
BEGIN
	SELECT * FROM UserInformation WHERE
	fName like '%' +@strng +'%' or
	lName like '%'+@strng+'%' or
	mName like '%'+ @strng +'%'
END
GO

CREATE PROC LogInUser
@username varchar(50),
@password varchar(MAX)

AS 

SELECT UL.userId,CONCAT(UPPER(UI.fName),' ',UPPER(UI.lName)) FROM UserLogin UL
INNER JOIN UserInformation UI
ON UL.userId = UI.userInfoId
WHERE
userName = @username and password = @password

GO