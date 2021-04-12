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
        //По шаблонам через рег. выражения записываем свойства
        public IEnumerable<string> GetAdsContent()
        {
            LinkedList<string> offers = ExtractAdsXmlContent();
            
            AdContainer adContainer = new AdContainer();
            Regex regex = new Regex(@"<!-- \[CATEGORY_ID=(?<CATEGORY_ID>(ID\d+))\] -->");
            Regex regex2 = new Regex(@"<!-- \[END_DATE=(?<END_DATE>(\S*))\] -->");
            Regex regex3 = new Regex(@"<id>(?<id>(\S*))</id>");
            Regex regex4 = new Regex(@"<title>(?<title>([\s\S]+?))</title>");
            Regex regex5 = new Regex(@"<description><!\[CDATA\[\r\n\r\n(?<description>([\s\S]+?))\r\n\r\n]]></description>");
            Regex regex6 = new Regex(@"<price>(?<price>(\d*))</price>");
            foreach (var offer in offers)
            {
                Ad ad = new Ad();
                //Console.WriteLine(regex.Match(offer).Groups["CATEGORY_ID"]);
                ad.CATEGORY_ID = regex.Match(offer).Groups["CATEGORY_ID"].ToString();

                //Console.WriteLine(regex2.Match(offer).Groups["END_DATE"]);
                ad.END_DATE = regex2.Match(offer).Groups["END_DATE"].ToString();

                //Console.WriteLine(regex3.Match(offer).Groups["id"]);
                ad.id = regex3.Match(offer).Groups["id"].ToString();

                //Console.WriteLine(regex4.Match(offer).Groups["title"]);
                ad.title = regex4.Match(offer).Groups["title"].ToString();

                //Console.WriteLine(regex5.Match(offer).Groups["description"]);
                ad.description = regex5.Match(offer).Groups["description"].ToString();

                //Console.WriteLine(regex6.Match(offer).Groups["price"]);
                ad.price = regex6.Match(offer).Groups["price"].ToString();

                //adContainer.AdContainProp();
            }
            return null;
        }
    }
}
