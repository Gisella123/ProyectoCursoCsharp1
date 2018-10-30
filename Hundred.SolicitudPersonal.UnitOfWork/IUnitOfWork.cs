using Hundred.SolicitudPersonal.Repositorios.Ejemplos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.SolicitudPersonal.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    { //agregar diferentes repositorios
        IClienteRepositorio _clienteRepositorio { get; }
        void Commit();
    }
}
