using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.APIs.Email
{
    class EmailDTO
    {
        public string Assunto { get; set; }
        public string RemetenteNome { get; set; }
        public string RemetenteEmail { get; set; }
        public string RemetenteSenha { get; set; }
        public string DestinatarioNome { get; set; }
        public string DestinatarioEmail { get; set; }
        public string Mensagem { get; set; }
    }
}
