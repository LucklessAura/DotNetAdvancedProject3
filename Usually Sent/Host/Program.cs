using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCF;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lansare server WCF...");
            try
            {
                ServiceHost host = new ServiceHost(typeof(WCF.ClassesWCF), new Uri("http://localhost:8000/IM"));
                foreach (ServiceEndpoint se in host.Description.Endpoints)
                {
                    Console.WriteLine("A (adress): {0} \nB(binding: {1}\nC (Contract): {2}\n", se.Address, se.Binding.Name, se.Contract.Name);

                }
                host.Open();
                Console.WriteLine("Server in executie. Se asteapta conexiuni...");
                Console.WriteLine("Apasati Enter pentru a opri serverul!");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured:\n" + e.Message + "\n" + e.StackTrace + "\n" + e.InnerException.Message);
                Console.WriteLine("Apasati Enter pentru a opri serverul!");
                Console.ReadKey();
            }
           
        }
    }
}
