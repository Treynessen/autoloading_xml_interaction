using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        AdContainer adContainer = new AdContainer();
        public Ad GetAdId(string adId) => adContainer[adId];
    }
}
