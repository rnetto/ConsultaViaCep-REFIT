using Newtonsoft.Json;

namespace consultaViaCep
{
    public class CepResposta
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")] 
        public string Uf { get; set; }

        public string MostraDadosCep()
        {
            return "Cep: " + Cep 
                +"\nLogradouro: "+ Logradouro 
                + "\nComplemento: " + Complemento 
                + "\nBairro: " + Bairro 
                + "\nLocalidade: " + Localidade 
                + "\nUF: " + Uf;
        }
    }
}
