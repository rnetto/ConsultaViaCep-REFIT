using Refit;
using System.Threading.Tasks;

namespace consultaViaCep
{
    public interface ICepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResposta> GetAddressAsync(string cep);
    }
}
