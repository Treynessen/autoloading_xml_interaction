using System.Collections.Generic;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        private LinkedList<Ad> ads;
        public IEnumerable<Ad> Ads => ads;
        public AdContainer()
        {
            ads = new LinkedList<Ad>();
        }
    }
}
