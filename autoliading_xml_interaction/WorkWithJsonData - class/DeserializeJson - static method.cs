using System.Collections.Generic;
using System.Text.Json;

namespace autoliading_xml_interaction
{
    // Создаем список из входящего Json файла
    public static partial class WorkWithJsonData
    {

        public static IEnumerable<T> DeserializeJson<T>(string json) => JsonSerializer.Deserialize(json, typeof(LinkedList<T>)) as IEnumerable<T>;

    }
}
