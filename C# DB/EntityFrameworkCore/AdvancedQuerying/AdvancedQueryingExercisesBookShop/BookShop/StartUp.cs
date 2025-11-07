namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            IncreasePrices(db);
        }

        //Problem 02
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            bool isCommandValid = Enum.TryParse(command, true, out AgeRestriction ageRestriction);

            if (isCommandValid)
            {
                IEnumerable<string> bookTitles = context
                    .Books
                    .AsNoTracking()
                    .Where(b => b.AgeRestriction == ageRestriction)
                    .OrderBy(b => b.Title)
                    .Select(b => b.Title)
                    .ToArray();

                foreach (string title in bookTitles)
                {
                    sb.AppendLine(title);
                }
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 06
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            string[] categoriesArr = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.ToLowerInvariant())
                .ToArray();

            if (categoriesArr.Any())
            {
                IEnumerable<string> bookTitles = context
                    .Books
                    .AsNoTracking()
                    .Where(b => b.BookCategories
                        .Select(bc => bc.Category)
                        .Any(c => categoriesArr.Contains(c.Name.ToLower())))
                    .OrderBy(b => b.Title)
                    .Select(b => b.Title)
                    .ToArray();

                foreach (var title in bookTitles)
                {
                    sb.AppendLine(title);
                }
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 08
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var authorsNames = context
                .Authors
                .AsNoTracking()
                .Where(a => a.FirstName != null &&
                            a.FirstName.EndsWith(input))
                .Select(a => new 
                {
                    a.FirstName,
                    a.LastName
                })
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToArray();

            foreach (var author in authorsNames)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName}");
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 12
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var authorCopies = context
                .Authors
                .AsNoTracking()
                .Select(a => new 
                {
                    a.FirstName,
                    a.LastName,
                    TotalCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.TotalCopies)
                .ToArray();

            foreach (var author in authorCopies)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName} - {author.TotalCopies}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}