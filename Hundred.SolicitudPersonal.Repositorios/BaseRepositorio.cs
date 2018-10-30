using System.Data;

namespace Hundred.SolicitudPersonal.Repositorios
{
    public abstract class BaseRepositorio
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }
        public BaseRepositorio(IDbTransaction _transaction)
        {
            Transaction = _transaction;
        }
    }
}
