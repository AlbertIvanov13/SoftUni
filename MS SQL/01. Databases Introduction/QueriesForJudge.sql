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

/* Problem 13 */
      CREATE TABLE [Directors](
	          [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[DirectorName] NVARCHAR(200) NOT NULL,
	       [Notes] NVARCHAR(MAX)
)

   CREATE TABLE [Genres](
	       [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[GenreName] VARCHAR(100) NOT NULL,
	    [Notes] VARCHAR(MAX)
)

      CREATE TABLE [Categories](
	          [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[CategoryName] VARCHAR(100) NOT NULL,
	       [Notes] NVARCHAR(MAX)
)

       CREATE TABLE [Movies](
	           [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	        [Title] NVARCHAR(200) NOT NULL,
	   [DirectorId] INT FOREIGN KEY REFERENCES [Directors]([Id]) NOT NULL,
	[CopyrightYear] INT,
       	   [Length] DECIMAL(5, 2),
	      [GenreId] INT FOREIGN KEY REFERENCES [Genres]([Id]) NOT NULL,
	   [CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]) NOT NULL,
	       [Rating] DECIMAL(3, 1),
	        [Notes] NVARCHAR(MAX)
)

INSERT INTO [Directors]([DirectorName], [Notes])
     VALUES
            ('Albert', 'cfjhvkjhfkhkhkehrkehrjkehrrrrrrrrr'),
            ('Stanislav', 'fofdidfoiodidoif'),
            ('Venci', 'fi3orieoreoriorioi'),
            ('Kalata', 'ffkf2kjdmcnxmcjdd'),
            ('Pepi', 'dfdkjoidpwopws')

INSERT INTO [Genres]([GenreName], [Notes])
     VALUES
            ('Horror', 'fdfdowioisdoviosvjv'),
            ('Commedy', NULL),
            ('Action', 'dfdflwspopov'),
            ('Thriller', 'dfdpwdpodcpc'),
            ('Mystery', 'fdfokoiosiov')

INSERT INTO [Categories]([CategoryName], [Notes])
     VALUES
            ('Slasher', 'sdkdjvkscjkjsc'),
            ('New slasher', 'sdsdspcpoclc'),
            ('Newer slasher', 'ld;fld;dlw;ld'),
            ('Family', 'dkdjkdjckjv'),
            ('Sad', 'ddoifodifodf')

INSERT INTO [Movies]([Title], [DirectorId], [CopyrightYear], [Length], [GenreId], [CategoryId], [Rating], [Notes])
     VALUES
            ('Spiderman', '1', NULL, NULL, '1', '1', NULL, NULL),
            ('The Conjouring', '2', NULL, NULL, '2', '2', NULL, NULL),
            ('Aquaman', '3', NULL, NULL, '3', '3', NULL, NULL),
            ('Avatar', '4', NULL, NULL, '4', '4', NULL, NULL),
            ('Chucky', '5', NULL, NULL, '5', '5', NULL, NULL)

GO