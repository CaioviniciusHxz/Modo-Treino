using System;
using System.ComponentModel;


namespace Curso{
    class Program{
        static void Main (string [] args){

           Post post = new Post(){
            Moment = new DateTime (21, 06, 2018, 13, 05, 44),
            Title = " Traveling to new Zealand",
            Content = "I'm goign to visit this wonder country!",
            Likes = 12, 

        };
       



        Comment comment1 = new Comment(){
            Text = "Have a nice trip"
        };
        Comment comment2 = new Comment(){
            Text = "Wow that's awesome!"
        };
      

        Post post2 = new Post(){
            Moment = new DateTime(21,06,2018, 23,14,19),
            Title ="Good nigth guys",
            Content = "See you tomorrow",
            Likes = 5
        };

        Comment comment3 = new Comment(){
            Text = "Good nigth"
        };
        Comment comment4 = new Comment(){
            Text = "May the Force be with you"
        };

        post.AddCommnet(comment1);
        post.AddCommnet(comment2);
        post2.AddCommnet(comment3);
        post2.AddCommnet(comment4);
    }
    }
}
