using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    public partial class CategoryContainer
    {
        Category[] prop;
        public Category this[string id]
        {
            get
            {
                switch (id)
                {
                    case "Id": return prop.FirstOrDefault();
                    case "Name": return prop.FirstOrDefault();
                    case "ImagesFolderPath": return prop.FirstOrDefault();
                    case "CategoryTemplate": return prop.FirstOrDefault();
                    default: return null;
                }
            }
        }
    }
}
