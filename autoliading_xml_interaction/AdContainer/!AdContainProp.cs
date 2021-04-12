using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace autoliading_xml_interaction
{
    partial class AdContainer
    {
        public IDictionary<string,string> AdContainProp()
        {
            Type myType = typeof(Ad);
            Dictionary<string, string> adsDict = new Dictionary<string, string>();
            foreach (PropertyInfo myT in myType.GetProperties())
            {
                //adsDict.Add(myT.Name.ToString(), myT.);

            }

            return null;
        }
    }
}
