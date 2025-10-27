
namespace SoftUni
{
    using Microsoft.EntityFrameworkCore;
    using SoftUni.Data;
    using SoftUni.Models;
    using System.Globalization;
    using System.Reflection.Metadata.Ecma335;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            SoftUniContext context = new SoftUniContext();

            string result = RemoveTown(context);

            Console.WriteLine(result);
        }

        /* Problem 03 */
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
            {
                e.FirstName,
                e.MiddleName,
                e.LastName,
                e.JobTitle,
                e.Salary
            }).ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 04 */
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .Where(e => e.Salary > 50_000)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 05 */
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Department,
                    e.Salary
                })
                .Where(d => d.Department.Name == "Research and Development")
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Department.Name} - ${employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 06 */
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Employee employee = context
                .Employees
                .First(e => e.LastName == "Nakov");

            Address address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            employee.Address = address;

            context.SaveChanges();

            var employeesAddresses = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToArray();

            return string.Join(Environment.NewLine, employeesAddresses);
        }

        /* Problem 07 */
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Select(ep => new
                {
                    ep.FirstName,
                    ep.LastName,
                    ep.Manager,
                    Projects = ep.EmployeesProjects.Where(ep => ep.Project.StartDate.Year >= 2001 & ep.Project.StartDate.Year <= 2003)
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                        StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        EndDate = ep.Project.EndDate != null
                            ? ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                            : "not finished"
                    })
                })
                .Take(10)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");
                if (employee.Projects.Any())
                {
                    foreach (var project in employee.Projects)
                    {
                        sb.AppendLine($"--{project.ProjectName} - {project.StartDate} - {project.EndDate}");
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 08 */
        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count())
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Select(a => new 
                {
                    a.AddressText,
                    a.Town.Name,
                    a.Employees
                })
                .Take(10)
                .ToArray();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.AddressText}, {address.Name} - {address.Employees.Count()} employees");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 09 */
        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(em => new
                {
                    em.FirstName,
                    em.LastName,
                    em.JobTitle,
                    Projects = em.EmployeesProjects
                    .Select(ep => new
                    {
                        ep.Project.Name
                    }).OrderBy(ep => ep.Name).ToArray()
                }).FirstOrDefault();

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            sb.Append(string.Join(Environment.NewLine, employee.Projects.Select(p => p.Name)));

            return sb.ToString().TrimEnd();
        }

        /* Problem 10 */
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departments = context.Departments
                .Where(e => e.Employees.Count > 5)
                .Select(d => new { 
                    d.Name,
                    d.Manager,
                    Employees = d.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName).Select(d => new {
                        d.FirstName,
                        d.LastName,
                        d.JobTitle
                    }).ToArray()
                })
                .OrderBy(d => d.Employees.Count())
                .ThenBy(d => d.Name)
                .ToArray();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.Name} - {department.Manager.FirstName} {department.Manager.LastName}");
                foreach (var employee in department.Employees)
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 11 */
        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var projects = context.Projects
                .Select(p => new { 
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .OrderByDescending(e => e.StartDate)
                .Take(10)
                .ToArray();

            foreach (var project in projects.OrderBy(p => p.Name))
            {
                sb.AppendLine($"{project.Name}");
                sb.AppendLine($"{project.Description}");
                sb.AppendLine($"{project.StartDate.ToString("M/d/yyyy h:mm:ss tt")}");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 12 */
        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" || e.Department.Name == "Information Services")
                .ToArray();

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12m;
            }

            context.SaveChanges();

            foreach (var updatedEmployee in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
            {
                sb.AppendLine($"{updatedEmployee.FirstName} {updatedEmployee.LastName} (${updatedEmployee.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 13 */
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new { 
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                }).OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 14 */
        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var projectToDelete = context.EmployeesProjects.Where(p => p.ProjectId == 2);

            context.EmployeesProjects.RemoveRange(projectToDelete);

            var project = context.Projects.FirstOrDefault(p => p.ProjectId == 2);

            context.Projects.Remove(project);

            context.SaveChanges();

            var projectsToDisplay = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToArray();

            foreach (var item in projectsToDisplay)
            {
                sb.AppendLine(item);
            }

            return sb.ToString().TrimEnd();
        }

        /* Problem 15 */
        public static string RemoveTown(SoftUniContext context)
        {
            int counter = 0;
            StringBuilder sb = new StringBuilder();

            var town = context.Towns.Where(t => t.Name == "Seattle").FirstOrDefault();

            var employees = context.Employees
                .Where(e => e.Address.TownId == town.TownId)
                .ToArray();

            foreach (var employee in employees)
            {
                employee.AddressId = null;
            }

            var addresses = context.Addresses
                .Where(a => a.TownId == town.TownId)
                .ToArray();

            foreach (var address in addresses)
            {
                counter++;
                context.Remove(address);
            }

            sb.AppendLine($"{counter} addresses in Seattle were deleted");


            context.Remove(town);

            context.SaveChanges();

            return sb .ToString().TrimEnd();
        }
    }
}