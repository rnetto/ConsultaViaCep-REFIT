using Refit;
using System;
using System.Threading.Tasks;

namespace consultaViaCep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepConsulta = RestService.For<ICepService>("http://viacep.com.br");

                Console.Write("Digite o Cep a ser consultado: ");
                string cepRecebe = Console.ReadLine();

                Console.WriteLine("Gerando dados do Cep " + cepRecebe);
                var cepDados = await cepConsulta.GetAddressAsync(cepRecebe);

                Console.WriteLine(cepDados.MostraDadosCep());
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro em consultar o Cep informado. " + e.Message);
            }
        }
    }
}
