using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CursoAlex
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> Alunos = new HashSet<int>();
            string[] curse = new string[] { "A", "B", "C" };
            

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"How many students for course {curse[i]}");
                int n = int.Parse(Console.ReadLine());
                for (int a = 0; a < n; a++){
                     int alunos = int.Parse(Console.ReadLine());
                     Alunos.Add(alunos);
                }

            }
            System.Console.WriteLine(Alunos.Count);



        }
    }
}