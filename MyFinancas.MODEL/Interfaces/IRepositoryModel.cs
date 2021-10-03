using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancas.MODEL.Interfaces
{
    public interface IRepositoryModel<T> : IDisposable where T : class
    {
        public void Cadastrar(T objeto);
        public void Alterar(T objeto);
        public void Excluir(T objeto);
        public List<T> ListarTodos();
    }
}