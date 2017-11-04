using System;
using System.ServiceModel;
using WcfService.Dto;

namespace WcfService.Services
{
    [ServiceContract]
    public interface IClienteService : IServices<Cliente>
    {
        [OperationContract]
        Cliente BuscarPorNome(string nome);
        [OperationContract]
        Cliente BuscarPorCpf(string cpf);
        [OperationContract]
        Cliente BuscarPorId(Guid id);
    }
}
