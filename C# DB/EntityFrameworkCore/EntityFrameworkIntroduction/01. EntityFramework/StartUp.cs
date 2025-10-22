
namespace SoftUni
{
    using SoftUni.Data;
    using SoftUni.Models;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            SoftUniContext context = new SoftUniContext();

            string result = AddNewAddressToEmployee(context);

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
    }
}