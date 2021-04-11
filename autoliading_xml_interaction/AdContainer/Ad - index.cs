using System.Linq;

namespace autoliading_xml_interaction
{
    public partial class AdContainer
    {
        public Ad this[string id] => ads.FirstOrDefault(p => p.id.Equals(id));
    }
}
