using System;
using System.Collections.Generic;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        LinkedList<Ad> ads = new LinkedList<Ad>();
        public AdContainer()
        {
            ads = new LinkedList<Ad>();
        }

        public AdContainer(LinkedList<Ad> ads)
        {
            if (ads != null) this.ads = ads;
            else this.ads = new LinkedList<Ad>();
        }
    }
}
