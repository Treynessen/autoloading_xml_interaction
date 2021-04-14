using System.Linq;

namespace autoliading_xml_interaction
{
    public partial class CategoryContainer
    {
        public Category this[string id] => categories.FirstOrDefault(p => p.Id.Equals(id) || p.Name.Equals(id));
    }
}
