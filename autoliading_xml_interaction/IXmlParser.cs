using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    interface IXmlParser
    {
        IEnumerable<Ad> GetAds();
    }
}
