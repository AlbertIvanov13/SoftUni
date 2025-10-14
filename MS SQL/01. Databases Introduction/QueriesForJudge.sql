/* Problem 04 */
INSERT INTO [Towns]([Id], [Name])
	 VALUES
            (1, 'Sofia'),
            (2, 'Plovdiv'),
            (3, 'Varna')

INSERT INTO [Minions]([Id], [Name], [Age], [TownId])
     VALUES
            (1, 'Kevin', 22, 1),
            (2, 'Bob', 15, 3),
            (3, 'Steward', NULL, 2)

GO

/* Problem 07 */
   CREATE TABLE [People](
	       [Id] INT PRIMARY KEY IDENTITY(1, 1),
	     [Name] NVARCHAR(200) NOT NULL,
	  [Picture] VARBINARY(2),
	   [Height] DECIMAL(5, 2),
	   [Weight] DECIMAL(5, 2),
	   [Gender] CHAR(1) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[Biography] NVARCHAR(MAX)
)

 ALTER TABLE [People]
ALTER COLUMN [Picture] VARBINARY(MAX)

INSERT INTO [People]([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography])
     VALUES
            ('Albert', NULL, 1.87, 2.40, 'm', '2003-04-13', NULL),
			('Stanislav', NULL, 2.00, 3.50, 'm', '2006-10-11', NULL),
			('Venci', NULL, 2.10, 4.00, 'm', '2005-12-10', NULL),
			('Veni', NULL, 1.60, 1.50, 'f', '1985-03-12', NULL),
			('Stefan', NULL, 1.70, 2.30, 'm', '2000-10-11', 'A short description...')

GO

/* Problem 08 */
        CREATE TABLE [Users](
	            [Id] BIGINT PRIMARY KEY IDENTITY(1, 1),
	      [Username] VARCHAR(30) NOT NULL UNIQUE,
	      [Password] VARCHAR(26) NOT NULL,
	[ProfilePicture] VARBINARY(MAX),
	 [LastLoginTime] DATETIME,
	     [IsDeleted] VARCHAR(5)
)

INSERT INTO [Users]([Username], [Password], [ProfilePicture], [LastLoginTime], [IsDeleted])
     VALUES
            ('Albert_Ivanov13', '12345678', NULL, NULL, NULL),
            ('Stanislav-222', '3847387', NULL, NULL, NULL),
            ('Venci@qqq', '219898fdf9', NULL, NULL, NULL),
            ('Venisdhjch', 'dewieuiuicuw898', NULL, NULL, NULL),
            ('STEFFF', '3983984', NULL, NULL, NULL)

GO