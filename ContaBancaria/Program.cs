using System;
using System.Runtime.ConstrainedExecution;

namespace ContaBancaria {
    class Program{
        static void Main(string[] args){

            
            System.Console.Write("Entre com o númemro da conta ");
            int idconta = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com o Nome do titular da conta ");
            string nameconta = Console.ReadLine();
            System.Console.Write("Deseja fazer um Deposito inicial? ");
            char op = char.Parse(Console.ReadLine());
            if( op == 'S' || op == 's'){
                System.Console.Write("Entre com o valor inicial ");
                double saldoconta = double.Parse(Console.ReadLine());
                Conta conta = new Conta(idconta, nameconta, saldoconta);
                System.Console.WriteLine(conta);
                System.Console.Write("Digite outro valor: ");
                double outrovalo = double.Parse(Console.ReadLine());
                conta.Deposito(outrovalo);
                System.Console.WriteLine($"Conta atualizada Número da conta: {conta.IdConta.ToString()}, titular: {conta.NameConta.ToString()}, saldo: {conta.SaldoConta.ToString()}");

                System.Console.Write("Valor de saque: ");
                outrovalo = double.Parse(Console.ReadLine());
                conta.saqueConta(outrovalo);
                System.Console.WriteLine($"Conta atualizada Número da conta: {conta.IdConta.ToString()}, titular: {conta.NameConta.ToString()}, saldo: {conta.SaldoConta.ToString()}");
                
                
            }
            else{
            Conta conta1 = new Conta(idconta, nameconta);
            System.Console.Write("Digite outro valor: ");
            double outrovalor = double.Parse(Console.ReadLine());
            conta1.Deposito(outrovalor);
            System.Console.WriteLine($"Conta atualizada Número da conta: {conta1.IdConta.ToString()}, titular: {conta1.NameConta.ToString()}, saldo: {conta1.SaldoConta.ToString()}");

            System.Console.Write("Valor de saque: ");
            outrovalor = double.Parse(Console.ReadLine());
            conta1.saqueConta(outrovalor);
            System.Console.WriteLine($"Conta atualizada Número da conta: {conta1.IdConta.ToString()}, titular: {conta1.NameConta.ToString()}, saldo: {conta1.SaldoConta.ToString()}");
            }
           

        }

    }

}