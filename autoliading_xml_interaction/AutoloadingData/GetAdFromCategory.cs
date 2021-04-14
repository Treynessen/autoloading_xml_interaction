using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    partial class AutoloadingData
    {
        /* я не понимаю почему когда я из метода мейн вызываю индексатор то все нормально а когда через метод GetAdId 
         * то все идет через жопу, и линкедлист adc тупо пустой, а как тогда нужно создавать объект AdContainer чтобы не выходило исключения
         * через отладчик кучу раз пробовал не получается никак. С этим методом тоже нихрена не понял что здесь должно появиться откуда я буду тянуть
         * объявления? тоже из adc или adcContainer
         * сделай комментарии плиз, я все исправлю.
         */
        public LinkedList<string> GetAdFromCategory(string catId)
        {
            
            return null;
        }
    }

}
