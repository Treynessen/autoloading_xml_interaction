using System.Linq;

namespace autoliading_xml_interaction
{
    public partial class AdContainer
    {
        public Ad this[string id] => ads.FirstOrDefault(p => p.Id.Equals(id) || p.Name.Equals(id));
    }
}
