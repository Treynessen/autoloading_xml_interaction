using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
