using System;

namespace autoliading_xml_interaction
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryContainer cat = new CategoryContainer();
            cat.ImportDataFromFile(Console.ReadLine().Trim('"'));
        }
    }
}
