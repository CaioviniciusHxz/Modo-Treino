using System;
using System.Diagnostics.CodeAnalysis;
using Execoes.Entites.Execption;
namespace Execoes.Entites{
    class Account{
        public int Number { get; set; }
        public string Holder  { get; set; }
        public double Balance { get; set; }
        public double WithdrowLimit  {get; set;} = 300;

        public Account(){}
        public Account(int number, string holder, double balance){
            Number = number;
            Holder = holder;
            Balance = balance;
            
        }
        public void Deposit (double amount){
            Balance += amount;
        }
        public void Withdraw(double amount){
            Balance -= amount;
        }

        public void Ex(double amount ){
         // Método responsavel por retornar as exceções   

            if(amount > WithdrowLimit || amount > Balance){
                throw new("Valor de saldo acima do limite ou saldo insuficiente");
            }
            Withdraw(amount);

        }
    }
}