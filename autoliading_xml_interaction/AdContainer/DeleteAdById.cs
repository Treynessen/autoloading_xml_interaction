using System.Collections.Generic;
using System.Linq;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        public void DeleteAdById(string id) => ads.Remove(this[id]);
    }
}
