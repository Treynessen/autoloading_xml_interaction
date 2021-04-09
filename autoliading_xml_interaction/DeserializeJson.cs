using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace autoliading_xml_interaction
{
    class DeserializeJson
    {
        LinkedList<JsonData> data = null;
        
        // Создаем список из входящего Json файла
        public void JsonReader()
        {
            using (StreamReader reader = new StreamReader(Console.ReadLine().Trim('"')))
            {
                data = JsonSerializer.Deserialize<LinkedList<JsonData>>(reader.ReadToEnd());
            }
            //foreach(var ddata in data)
            //{
            //    Console.WriteLine($"Id: {ddata.Id}, Name: {ddata.Name}, Path: {ddata.ImagesFolderPath}");
            //}
        }


    }
}
