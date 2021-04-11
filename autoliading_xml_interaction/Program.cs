using System;
using System.IO;

namespace autoliading_xml_interaction
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryContainer cat = new CategoryContainer();
            //cat.ImportDataFromFile(Console.ReadLine().Trim('"'));

            using(StreamReader reader = new StreamReader(Console.ReadLine().Trim('"')))
            {
                YandexXmlParser parser = new YandexXmlParser(reader.ReadToEnd());
                parser.ExtractAdsXmlContent();
            }
        }
    }
}
