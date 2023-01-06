using BancoCSharp.Models;

Console.WriteLine("**************************************");
Console.WriteLine("*********** Banco da Grazi ***********");
Console.WriteLine("**************************************");
Console.WriteLine();

var titular01 = new Titular(
    "Graziela Falk", 
    "14725896365", 
    "22988881111",
    new Endereco
{
    CEP = "28600000",
    Rua = "Rua ABC",
    Numero = 120
});

var titular02 = new Titular(
    "João Falk", 
    "96385274154", 
    "22999991111",
    new Endereco
{
    CEP = "28600000",
    Rua = "Rua ABC",
    Numero = 120
});

var conta01 = new ContaCorrente(titular01, 100.0, 500.0);

var conta02 = new ContaInvestimento(titular02);

var conta03 = new ContaPoupanca(titular02);

conta01.Depositar(50.0);

try
{
    conta01.Sacar(50.0);
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}


conta02.Depositar(500.0);
conta02.Sacar(100.0);
conta02.Transferir(conta03, 100.0);

conta03.Sacar(25.0);

conta01.ImprimirExtrato();
conta02.ImprimirExtrato();
conta03.ImprimirExtrato();

