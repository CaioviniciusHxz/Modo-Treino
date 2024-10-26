using System;
using System.Text.RegularExpressions;
namespace DesafioMatrix{
    class Program{
        static void Main(string[] args){
            System.Console.Write("Numero de linhas ");
            int linhas = int.Parse(Console.ReadLine());
            System.Console.Write("Numero de colunas ");
            int colunas = int.Parse(Console.ReadLine());
            int[,] mat = new int[linhas, colunas];

            for(int i=0; i < linhas; i++ ){
                System.Console.Write("Numeros ");
                string[] vect = Console.ReadLine().Split(' ');
                for(int c = 0; c < colunas; c++){
                    mat[i, c] = int.Parse(vect[c]);
                }
            } 
            System.Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());
            
            for(int i =0; i < linhas; i++){
                for(int c = 0; c< colunas; c++){
                    if(mat[i, c] == number){
                        System.Console.WriteLine( "posicões do número " + number + " : " + i + " , " + c );
                       if(c > 0){
                        System.Console.WriteLine("esquerda " + mat[i, c -1 ]);
                       }
                       if(i > 0){
                        System.Console.WriteLine("cima " + mat[i-1, c]);
                       }
                       if(c < colunas -1){
                        System.Console.WriteLine("direita " + mat[i, c + 1]);

                       }
                       if(i < linhas -1 ){
                        Console.WriteLine("baixo " + mat[i + 1, c]);
                       }
                    }
                }
            }     



        }
    }
}