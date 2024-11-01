using System;
using System.ComponentModel;


namespace Curso{
    class Program{
        static void Main (string [] args){

           Post post = new Post(
            DateTime.Parse("21/06/ 2018 13:05:44"),
            " Traveling to new Zealand",
            "I'm goign to visit this wonder country!",
             12); 

        
       



        Comment comment1 = new Comment(
            "Have a nice trip");
        
        Comment comment2 = new Comment(
            "Wow that's awesome!");
        
      

        Post post2 = new Post(
            DateTime.Parse("21/06/2018 23:14:19"),
            "Good nigth guys",
            "See you tomorrow",
            5
        );

        Comment comment3 = new Comment("Good nigth");
        
        Comment comment4 = new Comment("May the Force be with you");
        

        post.AddCommnet(comment1);
        post.AddCommnet(comment2);
        post2.AddCommnet(comment3);
        post2.AddCommnet(comment4);

        System.Console.WriteLine(post);
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(post2);
    }
    }
}
