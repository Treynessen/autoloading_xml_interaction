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
        public string[] GetRegexTemplate()
        {
            string[] adPropNames = GetAdPropNames();
            string[] regexTemplate = new string[adPropNames.Length];
            Regex regex = new Regex(@"<!-- \[" + adPropNames[0] + (@"=(ID\d*)"));
            regexTemplate[0] = regex.ToString();
            
            //string[0] = GetAdPropNames();
            //LinkedList<string> ads3 = new LinkedList<string>();
            //foreach (var iii in ads2)
            //{
            //    //Regex regex = new Regex(@"<!-- \[" + iii + (@"=(ID\d*)"));
            //    //Console.WriteLine(regex.Match().Groups[iii]);
            //    ////Regex regex2 = new Regex(iii + @"([\s\S]+?)" + iii);
            //    ////Console.WriteLine(regex2.Match(xmlFileContent).Value);
            //    ////Regex regex3 = new Regex(iii + @"([\s\S]+?)" + iii);
            //    ////Console.WriteLine(regex3.Match(xmlFileContent).Value);
            //    //ads3.AddLast(regex.Match(xmlFileContent).Value);
            //}
            return null;
        }
    }
}
