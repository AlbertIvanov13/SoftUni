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

/* Problem 14 */
      CREATE TABLE [Categories](
	          [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[CategoryName] VARCHAR(50) NOT NULL,
	   [DailyRate] DECIMAL(10, 2),
	  [WeeklyRate] DECIMAL(10, 2),
	 [MonthlyRate] DECIMAL(10, 2) NOT NULL,
	 [WeekendRate] DECIMAL(10, 2)
)

      CREATE TABLE [Cars](
	          [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	 [PlateNumber] VARCHAR(8) UNIQUE NOT NULL,
	[Manufacturer] VARCHAR(50),
	       [Model] VARCHAR(50),
	     [CarYear] INT,
	  [CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]) NOT NULL,
	       [Doors] INT,
 	     [Picture] VARBINARY(MAX),
	   [Condition] NVARCHAR(200),
	   [Available] BIT NOT NULL
)

   CREATE TABLE [Employees](
	       [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[FirstName] NVARCHAR(100) NOT NULL,
	 [LastName] NVARCHAR(100),
	    [Title] NVARCHAR(100),
	    [Notes] NVARCHAR(MAX)
)

             CREATE TABLE [Customers](
	                 [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[DriverLicenceNumber] VARCHAR(50) UNIQUE NOT NULL,
	           [FullName] NVARCHAR(200) NOT NULL,
	            [Address] NVARCHAR(200),
	               [City] NVARCHAR(200),
	            [ZIPCode] NVARCHAR(10),
	              [Notes] NVARCHAR(MAX)
)

          CREATE TABLE [RentalOrders](
	              [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	      [EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	      [CustomerId] INT FOREIGN KEY REFERENCES [Customers]([Id]) NOT NULL,
	           [CarId] INT FOREIGN KEY REFERENCES [Cars]([Id]),
	       [TankLevel] DECIMAL(10, 2),
	[KilometrageStart] INT,
	  [KilometrageEnd] INT,
	[TotalKilometrage] INT,
	       [StartDate] DATE,
	         [EndDate] DATE,
	       [TotalDays] INT,
	     [RateApplied] DECIMAL(10, 2),
	         [TaxRate] DECIMAL(10, 2),
	     [OrderStatus] NVARCHAR(50) NOT NULL,
	           [Notes] NVARCHAR(MAX)
)

INSERT INTO [Categories]([CategoryName], [DailyRate], [WeeklyRate], [MonthlyRate], [WeekendRate])
     VALUES
            ('Economy', 25.00, 150.00, 500.00, 30.00),
            ('Compact', 30.00, 180.00, 600.00, 35.00),
            ('SUV', 50.00, 300.00, 1000.00, 60.00)

INSERT INTO [Cars]([PlateNumber], [Manufacturer], [Model], [CarYear], [CategoryId], [Doors], [Condition], [Available])
     VALUES
            ('ABC123', 'Toyota', 'Corolla', 2020, 1, 4, 'Good', 1),
            ('XYZ789', 'Honda', 'Civic', 2019, 2, 4, 'Good', 1),
            ('SUV456', 'Ford', 'Explorer', 2021, 3, 5, 'Excellent', 1)

INSERT INTO [Employees] ([FirstName], [LastName], [Title])
     VALUES
            ('Alice', 'Smith', 'Manager'),
            ('Bob', 'Johnson', 'Sales'),
            ('Charlie', NULL, 'Clerk')

INSERT INTO [Customers] ([DriverLicenceNumber], [FullName], [Address], [City], [ZIPCode])
     VALUES
            ('DL12345', 'John Doe', '123 Main St', 'Pernik', '2300'),
            ('DL54321', 'Jane Roe', '456 Oak Ave', 'Sofia', '1000'),
            ('DL67890', 'Mike Lee', '789 Pine Rd', 'Plovdiv', '4000')

INSERT INTO [RentalOrders] 
            ([EmployeeId], [CustomerId], [CarId], [TankLevel], [KilometrageStart], 
			[KilometrageEnd], [TotalKilometrage], [StartDate], [EndDate], 
			[TotalDays], [RateApplied], [TaxRate], [OrderStatus])
     VALUES
            (1, 1, 1, 100.00, 12000, 12250, 250, '2025-09-01', '2025-09-05', 5, 125.00, 20.00, 'Completed'),
            (2, 2, 2, 80.00, 5000, 5250, 250, '2025-09-03', '2025-09-07', 5, 150.00, 20.00, 'Completed'),
            (3, 3, 3, 100.00, 20000, 20300, 300, '2025-09-05', '2025-09-10', 6, 300.00, 20.00, 'Active')

GO

/* Problem 15 */
   CREATE TABLE [Employees](
	       [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	 [LastName] NVARCHAR(50) NOT NULL,
	    [Title] NVARCHAR(200),
	    [Notes] NVARCHAR(MAX)
)

         CREATE TABLE [Customers](
	  [AccountNumber] INT IDENTITY(1, 1) PRIMARY KEY,
	      [FirstName] NVARCHAR(50) NOT NULL,
	       [LastName] NVARCHAR(50) NOT NULL,
	    [PhoneNumber] NVARCHAR(20),
 	  [EmergencyName] NVARCHAR(100),
	[EmergencyNumber] NVARCHAR(50),
	          [Notes] NVARCHAR(MAX)
)

    CREATE TABLE [RoomStatus](
	[RoomStatus] NVARCHAR(50) PRIMARY KEY,
	     [Notes] NVARCHAR(MAX)
)

  CREATE TABLE [RoomTypes](
	[RoomType] NVARCHAR(50) PRIMARY KEY,
	   [Notes] NVARCHAR(MAX)
)

 CREATE TABLE [BedTypes](
	[BedType] NVARCHAR(50) PRIMARY KEY,
	  [Notes] NVARCHAR(MAX)
)

    CREATE TABLE [Rooms](
	[RoomNumber] INT PRIMARY KEY,
	  [RoomType] NVARCHAR(50) FOREIGN KEY REFERENCES [RoomTypes]([RoomType]) NOT NULL,
	   [BedType] NVARCHAR(50) FOREIGN KEY REFERENCES [BedTypes]([BedType]) NOT NULL,
	      [Rate] DECIMAL(10, 2) NOT NULL,
	[RoomStatus] NVARCHAR(50) FOREIGN KEY REFERENCES [RoomStatus]([RoomStatus]) NOT NULL,
	     [Notes] NVARCHAR(MAX)
)

           CREATE TABLE [Payments](
	               [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	       [EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	      [PaymentDate] DATETIME2 NOT NULL,
	    [AccountNumber] INT FOREIGN KEY REFERENCES [Customers]([AccountNumber]) NOT NULL,
	[FirstDateOccupied] DATE NOT NULL,
	 [LastDateOccupied] DATE NOT NULL,
	        [TotalDays] INT NOT NULL,
 	    [AmountCharged] DECIMAL(10, 2) NOT NULL,
	          [TaxRate] DECIMAL(10, 2) NOT NULL,
	        [TaxAmount] DECIMAL(10, 2) NOT NULL,
	     [PaymentTotal] DECIMAL(10, 2) NOT NULL,
	            [Notes] NVARCHAR(MAX)
)

       CREATE TABLE [Occupancies](
	           [Id] INT IDENTITY(1, 1) PRIMARY KEY,
	   [EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	 [DateOccupied] DATETIME2 NOT NULL,
	[AccountNumber] INT FOREIGN KEY REFERENCES [Customers]([AccountNumber]) NOT NULL,
	   [RoomNumber] INT FOREIGN KEY REFERENCES [Rooms]([RoomNumber]) NOT NULL,
	  [RateApplied] DECIMAL(10, 2) NOT NULL,
	  [PhoneCharge] DECIMAL(10, 2) NOT NULL,
	        [Notes] NVARCHAR(MAX)
)

INSERT INTO [Employees] ([FirstName], [LastName], [Title], [Notes]) 
     VALUES
            ('Alice', 'Smith', 'Front Desk Manager', 'Handles check-ins and guest inquiries.'),
            ('Bob', 'Johnson', 'Housekeeping Supervisor', 'Manages cleaning staff and room inspections.'),
            ('Carol', 'Davis', 'Concierge', 'Assists guests with reservations and activities.')

INSERT INTO [Customers] ([FirstName], [LastName], [PhoneNumber], [EmergencyName], [EmergencyNumber], [Notes]) 
     VALUES
            ('Emma', 'Brown', '+359887123456', 'Olivia Brown', '+359887654321', 'Prefers quiet rooms.'),
            ('Liam', 'Miller', '+359888234567', 'Noah Miller', '+359888765432', 'Allergic to peanuts.'),
            ('Sophia', 'Taylor', '+359889345678', 'Mia Taylor', '+359889876543', 'VIP member.')

INSERT INTO [RoomStatus] ([RoomStatus], [Notes]) 
     VALUES
            ('Available', 'Room is ready for new guests.'),
            ('Occupied', 'Room is currently booked.'),
            ('Maintenance', 'Room is under maintenance or cleaning.')

INSERT INTO [RoomTypes] ([RoomType], [Notes]) 
     VALUES
            ('Single', 'One guest room, basic amenities.'),
            ('Double', 'Two guest room, standard amenities.'),
            ('Suite', 'Luxury room with additional amenities and space.')

INSERT INTO [BedTypes] ([BedType], [Notes]) 
     VALUES
            ('King', 'King size bed, comfortable for two.'),
            ('Queen', 'Queen size bed, standard comfort.'),
            ('Twin', 'Two single beds, suitable for sharing.')

INSERT INTO [Rooms] ([RoomNumber], [RoomType], [BedType], [Rate], [RoomStatus], [Notes]) 
     VALUES
            ('101', 'Single', 'Queen', 100.00, 'Available', 'Quiet room near the elevator.'),
            ('102', 'Double', 'King', 150.00, 'Available', 'Spacious room with balcony.'),
            ('201', 'Suite', 'King', 250.00, 'Available', 'Luxury suite with living area.')

INSERT INTO [Payments] ([EmployeeId], [PaymentDate], [AccountNumber], [FirstDateOccupied], [LastDateOccupied], [TotalDays], [AmountCharged], [TaxRate], [TaxAmount], [PaymentTotal], [Notes]) 
     VALUES
            (1, '2025-09-10', 1, '2025-09-05', '2025-09-09', 5, 500.00, 12.00, 60.00, 560.00, 'Paid in full by credit card.'),
            (2, '2025-09-12', 2, '2025-09-10', '2025-09-12', 3, 450.00, 10.00, 45.00, 495.00, 'Paid by cash.'),
            (3, '2025-09-14', 3, '2025-09-12', '2025-09-14', 3, 750.00, 15.00, 112.50, 862.50, 'Paid via bank transfer.')

INSERT INTO [Occupancies] ([EmployeeId], [DateOccupied], [AccountNumber], [RoomNumber], [RateApplied], [PhoneCharge], [Notes]) 
     VALUES 
            (1, '2025-09-05', 1, '101', 100.00, 10.00, 'Checked in smoothly.'),
            (2, '2025-09-10', 2, '102', 150.00, 0.00, 'Requested extra pillows.'),
            (3, '2025-09-12', 3, '201', 250.00, 20.00, 'VIP guest.')

GO

/* Problem 16 */
SELECT * FROM [Towns]
SELECT * FROM [Departments]
SELECT * FROM [Employees]

GO