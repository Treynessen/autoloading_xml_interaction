using System;
using System.Collections.Generic;
using System.Linq;

namespace autoliading_xml_interaction
{
    partial class CategoryContainer
    {
        public void DeleteCategoryByID(string id) => categories.Remove(this[id]);
    }
}
