using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Validacao.ER
{
    class ValidarNumero
    {
        /// <summary>
        /// Validação de dinheiro.
        /// </summary>
        /// <param name="valor">Valor a ser validado</param>
        public void ValidarDinheiro(string valor)
        {
            if (valor == string.Empty)
                throw new ArgumentException("O valor não pode estar em branco.");

            Regex regra1 = new Regex(@"^\d{0,}(,\d{2})?$");

            if (regra1.IsMatch(valor) == false)
                throw new ArgumentException("O valor não está num formato válido. Exemplo: 0,00");
        }

        /// <summary>
        /// Validação de Telefone Fixo.
        /// </summary>
        /// <param name="telefone">Telefone a ser validado</param>
        public void ValidarTelefoneFixo(string telefone)
        {
            if (telefone != "(  )     -")
            {
                if (telefone.Length != 14)
                    throw new ArgumentException("Digite o telefone corretamente");

                if (telefone.Substring(0, 4).Contains(" "))
                    throw new ArgumentException("Digite o telefone corretamente");

                if (telefone.Substring(5).Contains(" "))
                    throw new ArgumentException("Digite o telefone corretamente");

                Regex regra1 = new Regex(@"^\([0-9]{2}\)$");
                Regex regra2 = new Regex(@"^\([0-9]{2}\)[0-9]{4}-[0-9]{4}$");

                if (regra1.IsMatch(telefone.Substring(1, 2)) != false)
                    throw new ArgumentException("DD é inválido!");

                if (regra2.IsMatch(telefone) != false)
                    throw new ArgumentException("O telefone é invalido!");
            }
        }

        /// <summary>
        /// Validação de Celular.
        /// </summary>
        /// <param name="telefone">Celular a ser validado</param>
        public void ValidarTelefoneCelular(string telefone)
        {

            if (telefone != "(  )      -")
            {
                if (telefone.Length != 15)
                    throw new ArgumentException("Digite o celular corretamente");

                if (telefone.Substring(0, 4).Contains(" "))
                    throw new ArgumentException("Digite o celular corretamente");

                if (telefone.Substring(5).Contains(" "))
                    throw new ArgumentException("Digite o celular corretamente");

                Regex regra1 = new Regex(@"^\([0-9]{2}\)$");
                Regex regra2 = new Regex(@"^\([0-9]{2}\)[0-9]{4}-[0-9]{4}$");

                if (regra1.IsMatch(telefone.Substring(1, 2)) != false)
                    throw new ArgumentException("DD é inválido!");

                if (regra2.IsMatch(telefone) != false)
                    throw new ArgumentException("O telefone é invalido!");
            }
        }
    }
}
