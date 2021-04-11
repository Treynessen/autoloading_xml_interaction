using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
