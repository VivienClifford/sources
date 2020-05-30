using SimplaWebScrapper.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimplaWebScrapper.Workers
{
    class Scrapper
    {
        public List<string> Scrape(ScrapeCriteria scapeCriteria)
        {
            List<string> scrappedElements = new List<string>();

            MatchCollection matches = Regex.Matches(scapeCriteria.Data, scapeCriteria.Regex, scapeCriteria.RegexOption);

            foreach(Match match in matches)
            {
                if (!scapeCriteria.Parts.Any())
                {
                    scrappedElements.Add(match.Groups[0].Value);
                }
                else
                {
                    foreach(var part in scapeCriteria.Parts)
                    {
                        Match matchedPart = Regex.Match(match.Groups[0].Value, part.Regex, part.RegexOptions);

                        if (matchedPart.Success)
                            scrappedElements.Add(matchedPart.Groups[1].Value);
                    }
                }
            }

            return scrappedElements;
        }
    }
}
