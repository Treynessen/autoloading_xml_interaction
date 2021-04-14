using System;
using System.IO;

namespace autoliading_xml_interaction
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdContainer ad = new AdContainer();
            //ad.ImportDataFromFile(Console.ReadLine().Trim('"'));

            using (StreamReader reader = new StreamReader(Console.ReadLine().Trim('"')))
            {
                YandexXmlParser parser = new YandexXmlParser(reader.ReadToEnd());
                //parser.ExtractAdsXmlContent();
                AdContainer adContainer = new AdContainer();
                adContainer.AddRange(parser.GetAds());
                AutoloadingData autoloadingData = new AutoloadingData();
                string a = "Шуруповерт VortexTech 12 В li-ion новый";
                //Console.WriteLine(adContainer[a]);
                //string c = "ggfhfhfhf";
                autoloadingData.GetAdId(a);
                //parser.ExtractAdsXmlContent();
            }
        }
    }
}
