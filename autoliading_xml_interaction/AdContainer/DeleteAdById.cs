using System.Collections.Generic;
using System.Linq;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        public IEnumerable<Ad> DeleteAdById(string id) => ads.Where(p => !p.Id.Equals(id)).ToList();
    }
}
