using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace autoliading_xml_interaction
{
    partial class YandexXmlParser
    {
        public IEnumerable<string> ExtractAdsXmlContent()
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
