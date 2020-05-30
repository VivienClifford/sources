using System.Text.RegularExpressions;

namespace SimplaWebScrapper.Data
{
    class ScrapeCriteriaPart
    {
        public string Regex { get; set; }

        public RegexOptions RegexOptions { get; set; }
    }
}