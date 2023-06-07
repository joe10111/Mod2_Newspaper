using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; }

        public int ArticleCount()
        {
            return Articles.Count();
        }

        public int ReporterCount()
        {
            var countOfReporters = new List<Reporter> ();

            foreach (var article in Articles)
            {
                countOfReporters.Add(article.Reporter);
            }

            return countOfReporters.Count();
        }

        public List<string> ReporterNames()
        {
            var namesOfReporters = new List<string>();

            foreach (var article in Articles)
            {
                namesOfReporters.Add(article.Reporter.Name);
            }

            return namesOfReporters;
        }
    }
}
