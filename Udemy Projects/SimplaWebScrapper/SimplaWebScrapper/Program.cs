using SimplaWebScrapper.Builders;
using SimplaWebScrapper.Data;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace SimpleWebScrapper
{
    class Program
    {
        private const string method = "search";

        static void Main(string[] args)
        {

            //MatchCollection matches = Regex.Matches("balh baller eed This is my rat", "This is my [a-z]at");

            //foreach(var match in matches)
            //{
            //    Console.WriteLine(match);
            //}

            Console.WriteLine("Please enter which city you would like to scrape information from: ");

            var craigListCity = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please enter the CraigsList category that you would like to scrpe: ");

            var craigsListCategoryName = Console.ReadLine() ?? string.Empty;

            using (WebClient client = new WebClient())
            {
                string content = client.DownloadString($"http://{craigListCity.Replace(" ", string.Empty)}.craiglist.org/{method}/{craigsListCategoryName}");

                ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
                    .WithData(content)
                    .WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlink\"">(.*?)<a>")
                    .WithRegexOption(RegexOptions.ExplicitCapture)
                    .WithPart(new ScrapeCriteriaPartBuilder()
                                .WithRegex(@">(.*?)</a>")
                                .WithRegexOption(RegexOptions.Singleline)
                                .Build())
                    .WithPart(new ScrapeCriteriaPartBuilder()
                                .WithRegex(@">(.*?)</a>")
                                .WithRegexOption(RegexOptions.Singleline)
                                .Build())
            }


        }
    }
}
