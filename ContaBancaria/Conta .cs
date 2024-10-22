using System;
using System.Runtime.CompilerServices;

namespace ContaBancaria{
     class Conta{
        public int IdConta { get; private set; }
        public string NameConta{get; private set;}
        public double SaldoConta{get; private set;}


        public Conta(int idconta, string nameconta){
            IdConta = idconta;
            NameConta = nameconta;
        }
        public Conta(int idconta, string nameconta, double saldoconta){

            IdConta = idconta;
            NameConta = nameconta;
            SaldoConta = saldoconta;
        }    

        public void Deposito(double outrovalor){
            SaldoConta += outrovalor ;

        }
        public void saqueConta(double outrovalor){
            SaldoConta -= outrovalor + 5.0;
        }
        public override string ToString()
        {
            return "Dados Da conta :"
            + $"conta: {IdConta}, Titular: {NameConta}, Saldo: ${SaldoConta} ";

        }
    }
}