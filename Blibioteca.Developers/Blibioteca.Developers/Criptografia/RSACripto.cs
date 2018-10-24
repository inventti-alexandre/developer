using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Criptografia
{
    public class RSACripto
    {
        public List<string> GerarChaves()
        {
            System.Security.Cryptography.CspParameters cspParams = new System.Security.Cryptography.CspParameters { ProviderType = 1 };
            System.Security.Cryptography.RSACryptoServiceProvider rsaProvider = new System.Security.Cryptography.RSACryptoServiceProvider(cspParams);

            byte[] privateBytes = rsaProvider.ExportCspBlob(true);
            byte[] publicBytes = rsaProvider.ExportCspBlob(false);

            string privateKey = Convert.ToBase64String(privateBytes);
            string publicKey = Convert.ToBase64String(publicBytes);

            List<string> chaves = new List<string>();
            chaves.Add(privateKey);
            chaves.Add(publicKey);

            return chaves;
        }


        public string Criptografar(string chavePublica, string mensagem)
        {
            System.Security.Cryptography.CspParameters config = new System.Security.Cryptography.CspParameters { ProviderType = 1 };
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(config);

            byte[] chavePublicaBytes = Convert.FromBase64String(chavePublica);
            rsa.ImportCspBlob(chavePublicaBytes);

            byte[] mensagemBytes = Encoding.UTF8.GetBytes(mensagem);
            byte[] criptografiaBytes = rsa.Encrypt(mensagemBytes, false);

            string criptografia = Convert.ToBase64String(criptografiaBytes);
            return criptografia;
        }


        public string Descriptografar(string chavePrivada, string criptografia)
        {
            System.Security.Cryptography.CspParameters config = new System.Security.Cryptography.CspParameters { ProviderType = 1 };
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(config);

            byte[] chavePrivadaBytes = Convert.FromBase64String(chavePrivada);
            rsa.ImportCspBlob(chavePrivadaBytes);

            byte[] criptografiaBytes = Convert.FromBase64String(criptografia);
            byte[] mensagemBytes = rsa.Decrypt(criptografiaBytes, false);

            string mensagem = Encoding.UTF8.GetString(mensagemBytes);
            return mensagem;
        }
    }
}
