using Infra.Db.Model;

namespace WcfService.Adapter
{
    public static class ClienteAdapter
    {
        public static Cliente DtoParaEntidade(this Dto.Cliente cliente)
            => new Cliente
            {
                Id = cliente.Id,
                Cpf = cliente.Cpf,
                Nome = cliente.Nome
            };

        public static Dto.Cliente EntidadeParaDto(this Cliente cliente)
            => cliente != null ? new Dto.Cliente
            {
                Id = cliente.Id,
                Cpf = cliente.Cpf,
                Nome = cliente.Nome
            }:null;
    }
}
