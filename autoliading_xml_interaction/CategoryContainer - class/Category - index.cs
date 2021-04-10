using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    public partial class CategoryContainer
    {
        Category[] prop; // чо это?
        // В качестве аргумента параметра id передается идентификатор категории, который соответствует свойству Id
        // из класса Category. Внутри метода get мы должны найти эту самую категорию и вернуть её, представленную классом Category
        // Я без понятия, какую операцию ты пытаешься здесь проделать. В текущем состоянии твоя функция get будет работать
        // в одном режиме - будет возвращать первый объект Category из коллекции categories (действие return null я опускаю)
        // Что нужно было сделать в этом методе? Как я уже писал выше: "Внутри метода get мы должны найти эту самую категорию и вернуть её"
        // То есть, с помощью метода FirstOrDefault, которому в качестве аргумента можно передать предикат (логическая функции, которая
        // возвращает true или false), мы должны были найти объект Category в коллекции categories, свойство Id которого соответствует переданному
        // в параметр id значению. Если такой объект найти не удалось, тогда метод FirstOrDefault возвращает null
        
        // Вообще чо это за метода такой? Если вызвать FirstOrDefault для коллекции и не передавать никаких аргументов, то он вернет
        // первый объект в коллекции; если коллекция пустая, то этот метод вернет null. Если передать этому методу предикат, то он
        // вернет первый попавшийся объект, который соответствует предикату, иначе вернет null
        // В LINQ есть и другие методы для поиска данных: Where(предикат=null), First(предикат=null)
        // Where возвращает коллекцию объектов, которые соответствуют предикату
        // First ведет себя также, как и FirstOrDefault, но в случае, если коллекция не содержит элементов, или если не удалось найти
        // объект, тогда она кидает исключение
        public Category this[string id]
        {
            get
            {
                switch (id) 
                {
                    case "Id": return prop.FirstOrDefault(); // NullRefException
                    case "Name": return prop.FirstOrDefault(); // NullRefException
                    case "ImagesFolderPath": return prop.FirstOrDefault(); // NullRefException
                    case "CategoryTemplate": return prop.FirstOrDefault(); // NullRefException
                    default: return null; // ???
                }
            }
        }
    }
}
