using System;
using System.ServiceModel;

namespace MySelfHostService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CustomerService), new Uri[] { });
            host.Open();
            Console.WriteLine("Serviço rodando...");
            Console.WriteLine("Tecle para finalizar.");
            Console.ReadKey();
            host.Close();
        }
    }
}
