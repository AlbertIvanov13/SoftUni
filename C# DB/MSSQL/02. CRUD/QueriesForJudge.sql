/* Problem 02 */
SELECT * FROM [Departments]

GO

/* Problem 03 */
SELECT [Name] FROM [Departments]

GO

/* Problem 04 */
SELECT [FirstName],
	   [LastName],
	   [Salary]
FROM   [Employees]

GO

/* Problem 05 */
SELECT [FirstName],
	   [MiddleName],
	   [LastName]
FROM   [Employees]

GO

/* Problem 06 */
SELECT CONCAT([FirstName], '.', [LastName], '@', 'softuni.bg')
    AS [Full Email Address]
  FROM [Employees]

GO

/* Problem 07 */
SELECT DISTINCT [Salary] FROM [Employees]
       ORDER BY [Salary]

GO

/* Problem 08 */
SELECT * FROM [Employees]
        WHERE [JobTitle] = 'Sales Representative'

GO

/* Problem 09 */
SELECT [FirstName],
       [LastName],
	   [JobTitle]
  FROM [Employees]
 WHERE [Salary] BETWEEN 20000 AND 30000

GO

/* Problem 10 */
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName])
           AS [Full Name]
         FROM [Employees]
        WHERE [Salary] IN (25000, 14000, 12500, 23600)

GO

/* Problem 11 */
SELECT [FirstName],
	   [LastName]
  FROM [Employees]
 WHERE [ManagerID] IS NULL

GO

/* Problem 12 */
  SELECT [FirstName],
         [LastName],
	     [Salary]
    FROM [Employees]
   WHERE [Salary] >= 50000
ORDER BY [Salary] DESC

GO

/* Problem 13 */
SELECT TOP (5) [FirstName],
               [LastName]
		FROM   [Employees]
      ORDER BY [Salary] DESC

GO

/* Problem 14 */
SELECT [FirstName],
       [LastName]
  FROM [Employees]
 WHERE [DepartmentID] != 4

GO

/* Problem 15 */
SELECT * FROM [Employees]
     ORDER BY [Salary] DESC,
              [FirstName],
              [LastName] DESC,
              [MiddleName]

GO