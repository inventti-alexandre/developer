using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blibioteca.Developers.APIs.Correio
{
    class CorreioModel
    {
        public CorreioResponse Endereco(string CEP)
        {
            //Validar CEP
            Regex regra1 = new Regex(@"^[\d]{5}-[\d]{3}$");
            if (regra1.IsMatch(CEP) == false)
                throw new ArgumentException("O CEP digitado é inválido.");

            //Prepara URL
            string URL = $"https://viacep.com.br/ws/{CEP}/json";

            // Prepara cliente REST para fazer chamada
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            //Chamada Rest
            string data = rest.DownloadString(URL);
            var endereco = JsonConvert.DeserializeObject<CorreioResponse>(data);

            if (endereco.Logradouro == null)
                throw new ArgumentException("O CEP digitado não encontrou nenhum endereço!");

            return endereco;
        }
    }
}
