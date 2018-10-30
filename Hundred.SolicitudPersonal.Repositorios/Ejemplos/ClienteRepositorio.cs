using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Hundred.SolicitudPersonal.Modelo;


namespace Hundred.SolicitudPersonal.Repositorios.Ejemplos
{
    public class ClienteRepositorio : BaseRepositorio, IClienteRepositorio
    {
        public ClienteRepositorio(IDbTransaction _transaction) : base(_transaction)
        {
        }

        public void Add(Cliente entity)
        {
            string sql = "up_RegistrarCliente";
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@RUC", entity.RUC);
            parametro.Add("@RazonSocial", entity.razonSocial);
            int affectedRows = Connection.Execute(sql, param: parametro, transaction: Transaction, commandType: System.Data.CommandType.StoredProcedure);
        }

        public IEnumerable<Cliente> GetAll()
        {
            string sql = "SELECT * from tbl_cliente";

            return Connection.Query<Cliente>(sql, transaction: Transaction, commandType: System.Data.CommandType.Text);
        }

        public IEnumerable<Cliente> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
