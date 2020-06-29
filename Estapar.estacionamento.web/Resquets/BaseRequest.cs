using Estapar.estacionamento.web.Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Estapar.estacionamento.web.Resquets
{
    public static class BaseRequest<T> where T : class
    {
        public static List<T> Get(string url, int id = 0, bool isListaObj = true)
        {
            var client = SingletonHttpClient.GetInstanceHttpClient;
           var _url = id > 0 ? url + "/" + id : url;

            var responseTask = client.GetAsync(_url);
            responseTask.Wait();

            var result = responseTask.Result;
            List<T> resultado = null;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();

                if (isListaObj)
                {
                    resultado = BaseSerialize<T>.DeserializeListObject(readTask.Result);
                }
                else
                {
                    resultado = new List<T>() { BaseSerialize<T>.DeserializeObject(readTask.Result) };
                }
            }
            return resultado;
        }
        public static bool Delete(int id, string url)
        {
            var client = SingletonHttpClient.GetInstanceHttpClient;
          
            //HTTP DELETE
            var deleteTask = client.DeleteAsync(url + "/"+id.ToString());
            deleteTask.Wait();

            var result = deleteTask.Result;
            return result.IsSuccessStatusCode;
        }
        public static bool Post(T t, string url)
        {
            var client = SingletonHttpClient.GetInstanceHttpClient;
            
            var postTask = client.PostAsync(url, new StringContent(
            BaseSerialize<T>.SerializeObject(t),
            Encoding.UTF8,
            "application/json"));

            postTask.Wait();

            var result = postTask.Result;
            return (result.IsSuccessStatusCode);
        }
        public static bool Put(T t, string url)
        {
            var client = SingletonHttpClient.GetInstanceHttpClient;
            
            var postTask = client.PutAsync(url, new StringContent(
            BaseSerialize<T>.SerializeObject(t),
            Encoding.UTF8,
            "application/json"));

            postTask.Wait();

            var result = postTask.Result;
            return (result.IsSuccessStatusCode);
        }
    }
}