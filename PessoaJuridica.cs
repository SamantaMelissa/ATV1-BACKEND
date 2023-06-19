using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public class PessoaJuridica : Clientes, IPessoaJuridica
    {
        public string ?CNPJ {get; set;}

        public override void Pagar_Imposto(float v){
         
            this.Valor = v;
            // calculo do imposto
            this.valor_imposto = this.Valor*20/100;
            this.total = this.Valor + this.valor_imposto;
            
            // wilson - 100   -> R= 100*10/100  -> VT = 100 + R
            // bruno - 200 -> R = 200*10/100  -> VT =  200 + R
            // yuri - 500  -> R = 500*10/100  -> VT = 500 + R
        }
        public bool ValidarCnpj(string cpnj)
        {
            //    REGEX --> Expressoes regulares --> vários caracteres que representam partes de uma string
            // 00.000.000/0000-00
                // OU
            //  0000000000000

            if(Regex.IsMatch(cpnj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")){
                return true;
            }else{
                return false;
            }

        }
    }
}