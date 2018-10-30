using Hundred.SolicitudPersonal.Repositorios.Ejemplos;
using Hundred.SolicitudPersonal.Infraestructura;
using Hundred.SolicitudPersonal.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hundred.SolicitudPersonal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            _connection = new SqlConnection(Conexion.Cadena);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposing;
        //Cliente
        private IClienteRepositorio _clientepositorio;
        public IClienteRepositorio _ClienteRepositorio => _clientepositorio ?? (new ClienteRepositorio(_transaction));

        public IClienteRepositorio _clienteRepositorio => throw new NotImplementedException();

        //fin
        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepostitorios();
                Dispose();
            }
        }
        private void resetRepostitorios() { }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }
        private void dispose(bool disposing)
        {
            if (!_disposing)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposing = true;
            }
        }
        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}
