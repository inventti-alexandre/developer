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

        public void VerificarNome(string nome)
        {
            /* [A-Z] --> Obrigatoriamente a primeira letra tem que ser maiuscula.
             * 
             * [a-zà-ú] ---> minuscula com ou sem acento 
             * 
             * {2,} --- > tem que aparecer no minimo duas vezes o trecho anterior a essa parte 
             * 
             * [a-zà-ú]{2,} ----> O trecho [a-zà-ú] tem que se repetir no minimo duas vezes, ou seja tem que se
             *                    digitar duas minusculas após a primeira maiuscula 
             *                    
             * [A-Z][a-zà-ú]{2,} ---> A primeira palavra digitada tem que ter a primeira letra maiuscula seguidada de
             *                        no minimo duas minusculas ou com ascento ou sem ascento que tem que se repetir no minimo 
             *                        duas vezes.
             *                        
             * \s? ---> pode ter um espaço ou não após o ultimo caractere que foi digitado.
             * 
             * \s?[A-Z][a-zà-ú']?{2,}? ---> é obrigatorio que tenha um segundo nome 
             * 
             * [ ?]---> está agrupando como opicional o trecho (\s?[A-Z][a-zà-ú]?{2,}?)
             * 
             * [A-Z][a-zà-ú']? ---> assim como o anterior porém é opicional e possui o ' porque alguns nomes tem 
             * 
             * [\s?[A-Z][a-zà-ú']?{2,}?] ---> é opicional e pode ou não repetir
             * 
             * [\s?[A-Z][a-zà-ú']?{2,}?]{1,} ---> pode repetir toda a parte dentro do [] uma ou mais vezes, mas por toda a parte 
             *                                    não ser obrigatoria dentro, não é obrigatorio
             */

            string ex = @"^[A-Z][a-zà-ú]{2,}\s?[A-Z][a-zà-ú']?{2,}?[\s?[A-Z][a-zà-ú']?{2,}?]{1,}$";
            Regex re = new Regex(ex);

            if (re.IsMatch(nome) == true)
                throw new ArgumentException("Digite um nome e sobrenome corretamente!");
        }
    }
}
