using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public interface IPessoaFisica
    {
        // Contrato  - Conjunto de definições que serão utilizadas em classes herdadas.

        // Métodos não são implementados
        // A partir da versão 8 do C#, os métodos podem ser implementados
        // Todo filho que herdar a Interface, deverá chamar seus respectivos métodos.
        // Objetivo: Usado caso queira definir alguma ação.

        bool ValidarDataNascimento(DateTime dataNasc);
        bool ValidarCpf(string cpf);
    
    }
}