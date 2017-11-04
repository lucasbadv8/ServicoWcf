using System;
using System.Collections.Generic;
using System.Linq;
using Infra.Db.Model;

namespace Infra.Db.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public static List<Cliente> Clientes = new List<Cliente>();

        public void IncluirOuAlterar(Cliente cliente)
        {
            var index = Clientes.IndexOf(Clientes.Find(x=>x.Id.Equals(cliente.Id)));
            if (index < 0)
            {
                Clientes.Add(cliente);
            }
            else
            {
                Clientes.RemoveAt(index);
                Clientes.Insert(index, cliente);
            }

        }

        public void Incluir(Cliente cliente)
            => Clientes.Add(cliente);

        public Cliente BuscarPorNome(string nome)
            => Clientes.FirstOrDefault(x => x.Nome.Equals(nome));

        public Cliente BuscarPorCpf(string cpf)
            => Clientes.FirstOrDefault(x => x.Cpf.Equals(cpf));

        public Cliente BuscarPorId(Guid id)
            => Clientes.FirstOrDefault(x => x.Id.Equals(id));

        public bool Excluir(Cliente cliente)
            => Clientes.Remove(cliente);

        public bool Excluir(Guid id)
            => Clientes.Remove(Clientes.Find(x => x.Id.Equals(id)));

    }
}
