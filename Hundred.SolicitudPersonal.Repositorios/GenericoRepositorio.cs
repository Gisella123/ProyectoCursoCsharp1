using Hundred.SolicitudPersonal.Repositorios.Interfase;
using System;
using System.Collections.Generic;

namespace Hundred.SolicitudPersonal.Repositorios
{
    public class GenericoRepositorio<T> : IRepositorioGenerico<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
