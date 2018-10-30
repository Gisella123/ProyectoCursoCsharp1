using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundred.SolicitudPersonal.Repositorios.Interfase
{
    public interface IRepositorioGenerico<T> where T : class
    {

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(int id);
        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
    }
}
