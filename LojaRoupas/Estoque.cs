using System;

namespace LojaRoupas{
    class Estoque {
        
        public string[] Principal {get; set;}

        public Estoque( string[] Principal)
        {
            this.Principal = Principal;
            
        }
        public  bool ComEstoque(int quantidadeVenda){
        for(int i = 0; i < Principal.Length; i++){
          if(Principal[i] ==  Principal[3]){
            for(int c = 0; c < Principal[3].Length;){
                if(Principal[c] == quantidadeVenda.ToString()){
                  return true;
                }
            }

          }
        }
                  return false;
        }
    } 
}