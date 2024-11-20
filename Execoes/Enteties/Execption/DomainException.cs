using System;
namespace Execoes.Entites.Execption{
    class DomainExeception : ApplicationException{

        public DomainExeception(string message) : base(message){

        }

    }
}