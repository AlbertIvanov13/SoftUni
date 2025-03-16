using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed
{
    public class NewsFeed
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Article> Articles { get; set; }

        public NewsFeed(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Articles = new List<Article>(capacity);
        }

        public void AddArticle(Article article)
        {
            if (Articles.Count < Capacity && !Articles.Any(a => a.Title == article.Title))
            {
                Articles.Add(article);
            }
        }

        public bool DeleteArticle(string title)
        {
            if (Articles.Any(a => a.Title == title))
            {
                Articles.Remove(Articles.First(a => a.Title == title));
                return true;
            }

            return false;
        }

        public Article GetShortestArticle()
        {
            Article article = Articles.MinBy(a => a.WordCount);
            return article;
        }
        public string GetArticleDetails(string title)
        {
            if (Articles.Any(a => a.Title == title))
            {
                Article article = Articles.FirstOrDefault(a => a.Title == title);
                return article.ToString();
            }

            return $"Article with title '{title}' not found.";
        }

        public int GetArticlesCount()
        {
            return Articles.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            Articles = Articles.OrderBy(a => a.WordCount).ToList();
            sb.AppendLine($"{Name} newsfeed content:");
            foreach (Article article in Articles)
            {
                sb.AppendLine($"{article.Author}: {article.Title}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}