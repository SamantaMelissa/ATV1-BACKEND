using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public class Clientes
    {
        public string ?Nome {get; set;}
        public string ?Endereco {get; set;}
        public float Valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        public virtual void Pagar_Imposto(float v){
         
            this.Valor = v;
            // calculo do imposto
            this.valor_imposto = this.Valor*10/100;
            this.total = this.Valor + this.valor_imposto;
            
            // wilson - 100   -> R= 100*10/100  -> VT = 100 + R
            // bruno - 200 -> R = 200*10/100  -> VT =  200 + R
            // yuri - 500  -> R = 500*10/100  -> VT = 500 + R

        }
        
    }
}