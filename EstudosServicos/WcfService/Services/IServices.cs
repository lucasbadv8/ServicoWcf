using System;
using System.ServiceModel;

namespace WcfService.Services
{
    [ServiceContract]
    public interface IServices<in T> where T : class
    {
        [OperationContract]
        void IncluirOuAlterar(T cliente);
        [OperationContract]
        bool Excluir(Guid id);
    }
}
