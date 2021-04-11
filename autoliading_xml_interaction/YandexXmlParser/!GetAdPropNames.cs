using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    partial class YandexXmlParser
    {
        //Через рефлексию получаем спосик имен свойств класса Ad
        public LinkedList<string> GetAdPropNames()
        {
            Type myType = typeof(Ad);
            LinkedList<string> propNames = new LinkedList<string>();

            foreach (PropertyInfo mi in myType.GetProperties())
            {
                propNames.AddLast(mi.Name);
            }

            return propNames;
        }
    }
}
