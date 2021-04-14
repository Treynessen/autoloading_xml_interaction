using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        CategoryContainer categoryContainer = new CategoryContainer();
        public Category GetCategoryId(string categoryId) => categoryContainer[categoryId];
    }
}
