using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinancas.MODEL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MyFinancas.MODEL.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        public MyfinancasContext _oContexto; 
        public void Alterar(T objeto)
        {
            _oContexto.Entry(objeto).State = EntityState.Modified;
            _oContexto.SaveChanges();
        }

        public void Cadastrar(T objeto)
        {
            _oContexto.Set<T>().Add(objeto);
            _oContexto.SaveChanges();
        }

        public void Dispose()
        {
            _oContexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            _oContexto.Set<T>().Remove(objeto);
            _oContexto.SaveChanges();
        }

        public List<T> ListarTodos()
        {
            return _oContexto.Set<T>().ToList();
        }
    }
}