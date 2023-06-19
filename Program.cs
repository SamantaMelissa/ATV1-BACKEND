// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using _07a___SP2___Atividade_1___Desenvolvimento_de_sistema_de_controle_de_clientes;

// Validando o CNPJ da pessoa Juridica:
PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();

novaPj.Nome = "Bruno Henrique";
novaPj.Endereco = "Rua XXP";
novaPj.CNPJ = "12345678111111";

Console.WriteLine(@$"
    Nome: {novaPj.Nome}
    Endereço: {novaPj.Endereco}
    CNPJ: {novaPj.CNPJ}
    O CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.CNPJ)}
    "
);

// Validando o CPF da pessoa Física:

PessoaFisica metodoPf = new PessoaFisica();
PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Wilson Carvalho";
novaPf.Endereco = "Rua llll";
novaPf.dataNascimento = "25/09/1993";
novaPf.CPF= "01089077700";

if(novaPf.Endereco == ""){
     Console.WriteLine("ESCREVEEEE O ENDEREÇOOOOOOOOO");
}else{

Console.WriteLine(@$"
    Nome: {novaPf.Nome}
    Endereço: {novaPf.Endereco}
    Data de nascimento: {novaPf.dataNascimento}
    CPF:{novaPf.CPF}
    CPF é valido: {metodoPf.ValidarCpf(novaPf.CPF)}
");
}




// -------------------------------------------------------------------------------
//                          Código da aula passada
// -------------------------------------------------------------------------------
// PessoaFisica pf01 = new PessoaFisica();

// bool dataInformada = pf01.ValidarDataNascimento(new DateTime(2010, 01, 01));

// if(dataInformada == true){
//     Console.WriteLine("A pessoa física é maior de idade.");
// }else{

//     Console.WriteLine("A pessoa física é menor de idade");
// }


// PessoaFisica pf02 = new PessoaFisica();
// pf01.ValidarDataNascimento(new DateTime(2002,06,25));
// pf02.ValidarDataNascimento(new DateTime(1971,03,30));


// criando uma variável:
// float valor_pago;

// Console.WriteLine("Informe seu nome:");
// string var_nome = Console.ReadLine();

// Console.WriteLine("Informe seu endereço:");
// string var_endereco = Console.ReadLine();

// Console.WriteLine("Infome (f) para pessoa física, ou (j) para pessoa juridica");
// string var_tipo = Console.ReadLine();

// // laços de condição 

// if(var_tipo == "f"){
//     // Instanciar um classe / CRIAR UM OBJ
//     PessoaFisica pf01 = new PessoaFisica();

//     pf01.Nome = var_nome;
//     pf01.Endereco = var_endereco;

//     Console.WriteLine("Infome seu CPF:");
//     pf01.CPF = Console.ReadLine();

//     Console.WriteLine("Informe seu RG:");
//     pf01.RG = Console.ReadLine();

//     Console.WriteLine("Informe o valor da compra:");
//     valor_pago = float.Parse(Console.ReadLine());

//     // ATRIBUIR O MÉTODO AS INFORMAÇÕES QUE PREECHEMOS
//     pf01.Pagar_Imposto(valor_pago);

//     Console.WriteLine("---------------------------------");
//     Console.WriteLine("PESSOA FÍSICA");
//     Console.WriteLine("---------------------------------");
//     Console.WriteLine("\nNome: " +pf01.Nome);
//     Console.WriteLine("\nEndereço: " +pf01.Endereco);
//     Console.WriteLine("\nCPF: " +pf01.CPF);
//     Console.WriteLine("\nValor da compra: " +pf01.Valor.ToString("C"));
//     Console.WriteLine("\nValor do imposto: " +pf01.valor_imposto.ToString("C"));
//     Console.WriteLine("\nTotal a pagar: " +pf01.total.ToString("C"));

// }

// if(var_tipo == "j"){

//     PessoaJuridica pj01 = new PessoaJuridica();

//     pj01.Nome = var_nome;
//     pj01.Endereco = var_endereco;

//     Console.WriteLine("Informe seu CNPJ:");
//     pj01.CNPJ = Console.ReadLine();


//    Console.WriteLine("Informe o valor da compra:");
//     valor_pago = float.Parse(Console.ReadLine());

//     pj01.Pagar_Imposto(valor_pago);

//     Console.WriteLine("---------------------------------");
//     Console.WriteLine("PESSOA JURIDICA");
//     Console.WriteLine("---------------------------------");
//     Console.WriteLine("\nNome: " +pj01.Nome);
//     Console.WriteLine("\nEndereço: " +pj01.Endereco);
//     Console.WriteLine("\nCPF: " +pj01.CNPJ);
//     Console.WriteLine("\nValor da compra: " +pj01.Valor.ToString("C"));
//     Console.WriteLine("\nValor do imposto: " +pj01.valor_imposto.ToString("C"));
//     Console.WriteLine("\n Total a pagar: " +pj01.total.ToString("C"));




// }
