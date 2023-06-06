// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes;

// criando uma variável:
float valor_pago;

Console.WriteLine("Informe seu nome:");
string var_nome = Console.ReadLine();

Console.WriteLine("Informe seu endereço:");
string var_endereco = Console.ReadLine();

Console.WriteLine("Infome (f) para pessoa física, ou (j) para pessoa juridica");
string var_tipo = Console.ReadLine();

// laços de condição 

if(var_tipo == "f"){
    // Instanciar um classe / CRIAR UM OBJ
    PessoaFisica pf01 = new PessoaFisica();

    pf01.Nome = var_nome;
    pf01.Endereco = var_endereco;

    Console.WriteLine("Infome seu CPF:");
    pf01.CPF = Console.ReadLine();

    Console.WriteLine("Informe seu RG:");
    pf01.RG = Console.ReadLine();

    Console.WriteLine("Informe o valor da compra:");
    valor_pago = float.Parse(Console.ReadLine());

    // ATRIBUIR O MÉTODO AS INFORMAÇÕES QUE PREECHEMOS
    pf01.Pagar_Imposto(valor_pago);

    Console.WriteLine("---------------------------------");
    Console.WriteLine("PESSOA FÍSICA");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("\nNome: " +pf01.Nome);
    Console.WriteLine("\nEndereço: " +pf01.Endereco);
    Console.WriteLine("\nCPF: " +pf01.CPF);
    Console.WriteLine("\nValor da compra: " +pf01.Valor.ToString("C"));
    Console.WriteLine("\nValor do imposto: " +pf01.valor_imposto.ToString("C"));
    Console.WriteLine("\nTotal a pagar: " +pf01.total.ToString("C"));

}

if(var_tipo == "j"){

    PessoaJuridica pj01 = new PessoaJuridica();

    pj01.Nome = var_nome;
    pj01.Endereco = var_endereco;

    Console.WriteLine("Informe seu CNPJ:");
    pj01.CNPJ = Console.ReadLine();


   Console.WriteLine("Informe o valor da compra:");
    valor_pago = float.Parse(Console.ReadLine());

    pj01.Pagar_Imposto(valor_pago);

    Console.WriteLine("---------------------------------");
    Console.WriteLine("PESSOA JURIDICA");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("\nNome: " +pj01.Nome);
    Console.WriteLine("\nEndereço: " +pj01.Endereco);
    Console.WriteLine("\nCPF: " +pj01.CNPJ);
    Console.WriteLine("\nValor da compra: " +pj01.Valor.ToString("C"));
    Console.WriteLine("\nValor do imposto: " +pj01.valor_imposto.ToString("C"));
    Console.WriteLine("\n Total a pagar: " +pj01.total.ToString("C"));




}
