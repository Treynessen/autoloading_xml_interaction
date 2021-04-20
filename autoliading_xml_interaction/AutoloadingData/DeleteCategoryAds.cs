using System.Linq;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        public AdContainer DeleteCategoryAds(string catId)
        {
            foreach (var id in GetCategoryAds(catId).Select(ad => ad.Id))
            {
                adContainer.DeleteAdById(id);
            }
            return adContainer;
        }
    }
}