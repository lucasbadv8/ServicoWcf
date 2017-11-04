using System;
using Infra.Db.Repositorio;
using WcfService.Adapter;
using WcfService.Dto;

namespace WcfService.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clientes = new ClienteRepositorio();
        public void IncluirOuAlterar(Cliente cliente)
            => _clientes.IncluirOuAlterar(cliente.DtoParaEntidade());

        public bool Excluir(Guid id)
            => _clientes.Excluir(id);

        public Cliente BuscarPorNome(string nome)
            => _clientes.BuscarPorNome(nome).EntidadeParaDto();

        public Cliente BuscarPorCpf(string cpf)
            => _clientes.BuscarPorCpf(cpf).EntidadeParaDto();

        public Cliente BuscarPorId(Guid id)
            => _clientes.BuscarPorId(id).EntidadeParaDto();
    }
}
