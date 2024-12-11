using System;
using System.IO;
using Set.Entities;

namespace Set{
    class Program{
        static void Main(string [] args){

            HashSet<LogRecord> list = new HashSet<LogRecord>();

            System.Console.WriteLine("ENTER FILE FULL PATH");
            string Path = Console.ReadLine();

            try{
                using(StreamReader sr = File.OpenText(Path)){
                    while(!sr.EndOfStream){
                        string[] line =sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        list.Add(new LogRecord{UseName = name, Instate = instant});
                       
                    }
                    System.Console.WriteLine("Total user: " + list.Count);
                }
            }
            catch(IOException e){
                System.Console.WriteLine(e.Message);
            }
        }
    }
}