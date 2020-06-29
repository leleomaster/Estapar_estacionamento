using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Estapar.estacionamento.infrastructure.repository
{
    public class BaseTransactionScope
    {
        public static async Task WapperWrapper(Func<Task> action)
        {
            using (var transactionScope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                await action.Invoke();

                transactionScope.Complete();
            }
        }
    }
}
