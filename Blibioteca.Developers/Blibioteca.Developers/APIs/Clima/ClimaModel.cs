using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace Blibioteca.Developers.APIs.Clima
{
    class ClimaModel
    {

        public TempoResponse AdivisorTempo(string cidade)
        {
            CidadeResponse city = BuscarApiAdvisorCidade(cidade);
            TempoResponse tempo = BuscarApiAdivisorTempo(city.id.ToString());

            return tempo;
        }

        private CidadeResponse BuscarApiAdvisorCidade(string cidade)
        {
            // Cria objeto responsável por conversar com uma API
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            // Converte a pesquisa em formato URL
            cidade = HttpUtility.UrlEncode(cidade);

            // Chama API do Advisor, concatenando a cidade
            string resposta = rest.DownloadString($"http://apiadvisor.climatempo.com.br/api/v1/locale/city?name={cidade}&token=af3bea8ad6576d9b0c3064024edcd746");

            // Transforma a resposta do correio em lista de DTO
            List<CidadeResponse> cidades = JsonConvert.DeserializeObject<List<CidadeResponse>>(resposta);
            return cidades[0];
        }

        private TempoResponse BuscarApiAdivisorTempo(string id)
        {
            // Cria objeto responsável por conversar com uma API
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            // Converte a pesquisa em formato URL
            id = HttpUtility.UrlEncode(id);

            // Chama API do Advisor, concatenando a cidade
            string resposta = rest.DownloadString($"http://apiadvisor.climatempo.com.br/api/v1/weather/locale/{id}/current?token=af3bea8ad6576d9b0c3064024edcd746");

            // Transforma a resposta do correio em DTO
            TempoResponse tempo = JsonConvert.DeserializeObject<TempoResponse>(resposta);
            return tempo;
        }
    }
}
