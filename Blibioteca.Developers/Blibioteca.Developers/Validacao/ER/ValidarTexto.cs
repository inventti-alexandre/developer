using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Validacao.ER
{
    class ValidarTexto
    {
        /// <summary>
        /// Validação de email. NÃO ABRANGE TODOS OS EMAILs!
        /// </summary>
        /// <param name="email">Email que irá passar pela validação</param>
        public void ValidarEmail(string email)
        {
            if (email == string.Empty)
                throw new ArgumentException("O email não pode estar em branco.");

            Regex regra1 = new Regex(@"^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$");

            if (regra1.IsMatch(email) == false)
                throw new ArgumentException("O email não parece ser válido.");
        }

        /// <summary>
        /// Valida um nome que contenha apenas letras e espaços. NÃO PODERÁ CONTER ACENTO.
        /// </summary>
        /// <param name="nome">Nome que irá passar pela validação</param>
        public void ValidarNome(string nome)
        {
            nome = nome.Trim();

            if (nome == string.Empty)
                throw new ArgumentException("O nome não pode estar em branco.");

            Regex regra1 = new Regex(@"^[A-Za-z ]{0,}$");

            if (regra1.IsMatch(nome) == false)
                throw new ArgumentException("O nome pode conter apenas letras e espaços.");
        }
    }
}
