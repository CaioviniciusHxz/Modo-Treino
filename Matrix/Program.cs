
//Exercicio do curso
using System;
using System.Xml;
namespace Matrix{
    class Program{
        static void Main(string[]args){
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int [n, n];
            
            for(int i = 0; i < n; i++){
                string[] vect = Console.ReadLine().Split(' ');
                
                for(int c = 0; c < n; c++) {
                    mat[i, c] = int.Parse(vect[c]);
                }
            }
            System.Console.WriteLine(" Valores na diagonal");
            for(int i = 0; i< n; i++){
                System.Console.Write(mat[i,i] + " ");
            }
            System.Console.WriteLine();
        }
    }
}