using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    public class Ad
    {
        private string category_id;
        public string CATEGORY_ID { get => category_id;  set => category_id += value; }
        public string END_DATE { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string price { get; set; }
    }
}
