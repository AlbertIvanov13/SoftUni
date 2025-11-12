using AcademicRecordsApp.Data;
using Microsoft.Extensions.Configuration;

namespace AcademicRecordsApp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            AcademicRecordsDbContext context = new AcademicRecordsDbContext();

            var grades = context.Grades
                .Where(g => g.Value >= 5.00m)
                .Select(g => new 
                {
                    StudentName = g.Student.FullName,
                    ExamName = g.Exam.Name,
                    GradeValue = g.Value
                })
                .ToList();

            foreach (var grade in grades)
            {
                Console.WriteLine($"{grade.StudentName} - {grade.ExamName}: {grade.GradeValue:f2}");
            }
        }
    }
}