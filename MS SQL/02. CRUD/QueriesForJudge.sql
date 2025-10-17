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