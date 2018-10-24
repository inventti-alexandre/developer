using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Criptografia
{
    class MD5Cripto
    {
        public string Criptografar(string mensagem)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] mensagemBytes = Encoding.UTF8.GetBytes(mensagem);
            byte[] criptografiaBytes = md5.ComputeHash(mensagemBytes);
            string criptografia = Convert.ToBase64String(criptografiaBytes);

            return criptografia;
        }
    }
}
