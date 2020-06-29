using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Estapar.estacionamento.web.Patterns.Singleton
{
    public static class BaseSerialize<T> where T : class
    {
        public static string SerializeObject(T t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }
        
        public static List<T> DeserializeListObject(string t)
        {
            return new JavaScriptSerializer().Deserialize<List<T>>(t);
        }

        public static T DeserializeObject(string t)
        {
            return new JavaScriptSerializer().Deserialize<T>(t);
        }
    }
}