using System;
using System.Collections.Generic;
using System.Net;
using Votacao.Entites;

namespace Votacao{
    class Program{
        static void Main (string [] arg){
            string Path = @"/home/caio-vinicius/ModoTreino/Votacao/Arquivos/Dados.txt";
            Dictionary<string, int> Contagem = new Dictionary<string, int>();

            using(StreamWriter sw = new StreamWriter(Path)){
                System.Console.Write("QUANTIDADE DE URNAS :");
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i< n ; i++){
                   string[] list = Console.ReadLine().Split('-');
                   string name = list[0];
                   int votos = int.Parse(list[1]);
                   Contagem.Add(name,votos);
                }
                foreach(var cand in Contagem){
                    sw.WriteLine(cand);
                }
            }
        }
    }
}