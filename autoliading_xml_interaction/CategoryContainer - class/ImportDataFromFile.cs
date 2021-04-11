using System.IO;

namespace autoliading_xml_interaction
{
    partial class CategoryContainer
    {
        public void ImportDataFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath)) 
            {   
                foreach (var category in WorkWithJsonData.DeserializeJson<Category>(reader.ReadToEnd())) categories.AddLast(category); 
            }
        }
    }
}
