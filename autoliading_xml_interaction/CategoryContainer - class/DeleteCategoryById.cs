using System;
using System.Collections.Generic;
using System.Linq;

namespace autoliading_xml_interaction
{
    partial class CategoryContainer
    {
        public IEnumerable<Category> DeleteCategoryByID(string id) => categories.Where(p => !p.Equals(id)).ToList();
    }
}
