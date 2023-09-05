// See https://aka.ms/new-console-template for more information
using controleContas;

Conta conta1 = new Conta(123456);
Conta conta2 = new Conta(654321);
conta2.Saldo = 2341.42m;
conta1.Saldo = conta2.Saldo * 0.7m;

//conta1._numero = 123456;
Console.WriteLine($"Número da conta: {conta1.Numero}");
