
namespace autoliading_xml_interaction
{
    //Храним свйоства для массива из входящего Json файла
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImagesFolderPath { get; set; }
        public string CategoryTemplate { get; set; }

        // Релизовать индексатор в классе CategoryContainer public Category this[string id]
        // С помощью метода FirstOrDefault() из LINQ ты должен получить категорию. которая будет передана в параметр id (смотри индексатор выше)
        // В индексаторе релизовать get'ер. который возвращает Category с совпадающим Id 
    }
}
