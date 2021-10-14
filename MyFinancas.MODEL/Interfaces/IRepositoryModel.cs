using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancas.MODEL.Interfaces
{
    public interface IRepositoryModel<T> : IDisposable where T : class
    {
        public T Cadastrar(T objeto);
        public T Alterar(T objeto);
        public void Excluir(T objeto);
        public List<T> ListarTodos();
        public T SelecionarPK(params object[] variavel);
    }
}