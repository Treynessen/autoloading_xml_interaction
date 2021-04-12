using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace autoliading_xml_interaction
{
    partial class YandexXmlParser
    {
        //Делим полученный xml файл с объявлениями на список с объявлениями
        private LinkedList<string> ExtractAdsXmlContent()
        {
            Regex regex = new Regex(@"<offer>([\s\S]+?)</offer>");
            Match match = regex.Match(xmlFileContent);
            LinkedList<string> adsList = new LinkedList<string>();
            while (match.Success)
            {
                adsList.AddLast(match.Value);
                match = match.NextMatch();
            }
            return adsList;
        }
    }
}
