using System;
using Infra.Db.Model;

namespace Infra.Db.Repositorio
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        Cliente BuscarPorNome(string nome);
        Cliente BuscarPorCpf(string cpf);
        Cliente BuscarPorId(Guid id);
    }
}
