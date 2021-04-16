using System;

namespace autoliading_xml_interaction
{
    // Храним свойства для массива из входящего XML файла
    public class Ad
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime EndDate { get; set; }
        public string CategoryId { get; set; }
    }
}
