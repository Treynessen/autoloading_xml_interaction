using System.Collections.Generic;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        public void AddRange(IEnumerable<Ad> ads)
        {
            foreach (var ad in ads) this.ads.AddLast(ad);
        }
    }
}
