using System;
using System.ServiceModel;
using WcfService.Services;

namespace Hosting
{
    class Hosting
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(ClienteService)))
            {
                try
                {
                    var endereco = new Uri("http://localhost:5000/clientes");
                    host.AddServiceEndpoint(typeof(IClienteService),new BasicHttpBinding(),endereco);
                    host.Open();
                    ExibirInfoServico(host);
                    Console.ReadKey();

                    host.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    host.Abort();
                    Console.ReadLine();
                }

            }
            
        }

        public static void ExibirInfoServico(ServiceHost service)
        {
            Console.WriteLine($"{service.Description.ServiceType} online" );
            foreach (var endPoint in service.Description.Endpoints)
                Console.WriteLine(endPoint.Address);
        }
    }
}
