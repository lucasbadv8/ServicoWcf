using System;
using Infra.Db.Model;

namespace Infra.Db.Repositorio
{
    public interface IRepositorio<T> where T : Entidade
    {
        void IncluirOuAlterar(T cliente);
        bool Excluir(T cliente);
        bool Excluir(Guid id);
    }
}
