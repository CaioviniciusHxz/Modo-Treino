using System;
using MetodoAbstratos.Entities.Enums;
using MetodoAbstratos.Entities;
using System.Globalization;

namespace MetodoAbstratos{
    class Program{
        static void Main(string[]args){
            List<Shape> shape = new List<Shape>();

            System.Console.WriteLine("Enter the number of shape: ");

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++){
                System.Console.WriteLine($"Shape #{i} data: ");
                System.Console.WriteLine("Rectangle or Circle (r/c)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/ Blue/ Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(response == 'r'){
                    System.Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    System.Console.Write("Heigth: ");2
                    
                    double heigth = double.Parse(Console.ReadLine());
                    shape.Add(new Rectangle(width, heigth, color));


                }else if(response == 'c'){
                    System.Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape.Add(new Circles (radius, color));
                }
                else{
                    System.Console.WriteLine("Opção incorreta");
                }
            }
        
            System.Console.WriteLine("Shape Areas");
            foreach(Shape item in shape){
                System.Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        
        }


    }
}