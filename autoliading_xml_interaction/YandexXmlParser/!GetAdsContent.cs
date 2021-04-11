using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace autoliading_xml_interaction
{
    partial class YandexXmlParser
    {
        //Получаем значения по шаблонам regex
        public IEnumerable<string> _GetAdsContent()
        {
            LinkedList<string> ads = (LinkedList<string>)ExtractAdsXmlContent();
            //for (int i = 0; i < ads.Count; i++)
            
            
            foreach (var ii in ads)
            {

            }


            
            return null;
        }
    }
}