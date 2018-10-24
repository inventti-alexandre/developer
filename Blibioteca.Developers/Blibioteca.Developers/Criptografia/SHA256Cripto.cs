using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Criptografia
{
    public class SHA256Cripto
    {

        public string Criptografar(string mensagem)
        {
            System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] mensagemBytes = Encoding.UTF8.GetBytes(mensagem);
            byte[] criptografiaBytes = sha256.ComputeHash(mensagemBytes);
            string criptografia = Convert.ToBase64String(criptografiaBytes);

            return criptografia;
        }
    }
}
