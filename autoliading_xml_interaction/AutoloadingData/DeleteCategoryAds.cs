using System.Collections.Generic;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        public AdContainer DeleteCategoryAds(string catId)
        {
            foreach (var id in (List<string>)GetCategoryAds(catId))
            {
                adContainer.DeleteAdById(id);
            }
            return adContainer;
        }
    }

}
