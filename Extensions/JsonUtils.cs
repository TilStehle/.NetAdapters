using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
    class JsonUtils
    {
        internal T1 FromJson<T1>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T1>(jsonString);
        }

        internal string ToJson(Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
