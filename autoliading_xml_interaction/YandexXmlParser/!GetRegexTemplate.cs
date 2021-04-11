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
        public LinkedList<string> GetRegexTemplate()
        {
            LinkedList<string> ads2 = GetAdPropNames();
            LinkedList<string> ads3 = new LinkedList<string>();
            foreach (var iii in ads2)
            {
                //Regex regex = new Regex(@"<!-- \[" + iii + (@"=(ID\d*)"));
                //Console.WriteLine(regex.Match().Groups[iii]);
                ////Regex regex2 = new Regex(iii + @"([\s\S]+?)" + iii);
                ////Console.WriteLine(regex2.Match(xmlFileContent).Value);
                ////Regex regex3 = new Regex(iii + @"([\s\S]+?)" + iii);
                ////Console.WriteLine(regex3.Match(xmlFileContent).Value);
                //ads3.AddLast(regex.Match(xmlFileContent).Value);
            }
            return ads3;
        }
    }
}
