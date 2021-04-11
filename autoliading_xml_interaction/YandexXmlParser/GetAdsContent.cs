using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{ 
    partial class YandexXmlParser
    {
        public IEnumerable<string> GetAdsContent()
        {
            LinkedList<string> offers = ExtractAdsXmlContent();
            Ad ad = new Ad();
            Regex regex = new Regex(@"<!-- \[CATEGORY_ID=(?<CATEGORY_ID>(ID\d+))\] -->");
            foreach (var offer in offers)
            {
                Console.WriteLine(regex.Match(offer).Groups["CATEGORY_ID"]);
                ad.CATEGORY_ID = regex.Match(offer).Groups["CATEGORY_ID"].ToString();
            }

            return null;
        }
    }
}
