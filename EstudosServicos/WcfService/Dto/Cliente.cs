using System;
using System.Runtime.Serialization;

namespace WcfService.Dto
{
    public class Cliente 
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cpf { get; set; }
    }
}
