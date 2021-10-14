using Microsoft.EntityFrameworkCore;
using MyFinancas.MODEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancas.MODEL.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected MyfinancasContext oContexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            oContexto = new MyfinancasContext();
        }

        public T Alterar(T objeto)
        {
            oContexto.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                oContexto.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            oContexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            oContexto.Set<T>().Remove(objeto);

            if (_SaveChanges)
            {
                oContexto.SaveChanges();
            }
        }

        public void ExcluirPK(params object[] variavel)
        {
            var obj = SelecionarPK(variavel);
            oContexto.Remove(obj);
        }

        public T Cadastrar(T objeto)
        {
            oContexto.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                oContexto.SaveChanges();
            }

            return objeto;
        }

        public void SaveChanges()
        {
            oContexto.SaveChanges();
        }

        public T SelecionarPK(params object[] variavel)
        {
            return oContexto.Set<T>().Find(variavel);
        }

        public List<T> ListarTodos()
        {
            return oContexto.Set<T>().ToList();
        }
    }
}
