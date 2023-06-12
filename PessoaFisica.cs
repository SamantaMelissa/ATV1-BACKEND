using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public class PessoaFisica : Clientes, IPessoaFisica
    {
        public string CPF {get; set;}
        public string RG {get; set;}
        public string dataNascimento {get; set;}
 
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            // Dt atual - Dt nascimento
            DateTime dataAtual;
            dataAtual = DateTime.Today;

            double anos;
            // 564765745,7587657685768547
            anos = (dataAtual - dataNasc).TotalDays / 365;
            
            Console.WriteLine($"{anos}");

            if(anos >= 18){
                // Maior de idade
                Console.WriteLine("A pessoa física é maior de idade.");
                return true;
            }
            
            // Menor de idade
            return false;
            Console.WriteLine("A pessoa física é menor de idade");
           
        }

    }
}