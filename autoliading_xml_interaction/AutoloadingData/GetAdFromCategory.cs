using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        public IEnumerable<Ad> GetAdFromCategory(string catId) => adContainer.Ads.Where(p => p.Id.Equals(catId)).ToList();
    }

}
