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
        //Через рефлексию получаем массив имен свойств класса Ad
        public string[] GetAdPropNames()
        {
            Type myType = typeof(Ad);
            int x = 0;
            foreach (PropertyInfo myT in myType.GetProperties())
            {
                x++;
                
            }
            string[] adPropNames = new string[x];
            int y = 0;
            foreach (PropertyInfo myT in myType.GetProperties())
            {

                adPropNames[y] = myT.Name.ToString();
                y++;
            }
            return adPropNames;
        }
    }
}
