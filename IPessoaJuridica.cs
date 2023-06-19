using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cpnj);
    }
}