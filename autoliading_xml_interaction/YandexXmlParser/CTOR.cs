namespace autoliading_xml_interaction
{
    partial class YandexXmlParser : IXmlParser
    {
        private string xmlFileContent;
        public YandexXmlParser(string xmlFileContent)
        {
            this.xmlFileContent = xmlFileContent;
        }
    }
}
