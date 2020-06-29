using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Estapar.estacionamento.application
{
    public sealed class BaseExceptionSystem<T>
    {
        public static async Task BaseHandleExcetion(Func<Task> action, string appName)
        {
            try
            {
               await action.Invoke();
            }
            catch (SqlException sqlEx)
            {
                // log = Stack trace, classe and method, appName
            }
            catch (TimeoutException tmOut)
            {
                // log = Stack trace, classe and method, appName
            }
            catch (NullReferenceException exNullRef)
            {
                // log = Stack trace, classe and method, appName
            }
            catch (Exception ex)
            {
                // log = Stack trace, classe and method, appName
            }
        }
    }
}
