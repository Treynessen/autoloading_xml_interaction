using System.Collections.Generic;
using System.Linq;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        public IEnumerable<Ad> DeleteCategoryAds(string catId) => adContainer.Ads.Where(p => !p.Id.Equals(catId)).ToList();  
    }

}
