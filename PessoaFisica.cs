using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public class PessoaFisica : Clientes, IPessoaFisica
    {
        public string ?CPF {get; set;}
        public string ?RG {get; set;}
        public string ?dataNascimento {get; set;}

        public bool ValidarCpf(string cpf)
        {
            //    REGEX --> Expressoes regulares --> vários caracteres que representam partes de uma string
            //  000.000.000-00
                // OU
            //  00000000000
            // ---------------------------------------------------------------------------------------------
            // (\d) -> Percorre
            // (\d{5}) -> Percorre por 5 caracteres
            // (/d{5}?) -> Percorre os 5 caracteres, e depois encontra o ?
            // ---------------------------------------------------------------------------------------------
            //  (|) -> Ou
            // Hoje está frio OU Está chovendo -> V
            // Hoje está frio E Está chovendo -> F
            // V ou F ==> V
            // V e F ==> F
            // V e V ==> v
            // F e F ==> F
            if(Regex.IsMatch(cpf, @"(^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11}))")){
                return true;
            }else{
                return false;

            }         
        }

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
            Console.WriteLine("A pessoa física é menor de idade");
            return false;
           
        }

    }
}