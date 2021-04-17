using System.IO;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        public void ImportDataFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                YandexXmlParser parser = new YandexXmlParser(reader.ReadToEnd());
            }
        }
    }
}
