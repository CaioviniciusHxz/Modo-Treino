using System.Text;

namespace Curso{
    class Post{
        public DateTime Moment{get; set;}
        public string Title{get; set;}
        public string Content{get; set;}
        public int Likes {get; set;}

        public List<Comment> comments {get; set;} = new List<Comment>();

        public Post(){
        
        }
        public void AddCommnet(Comment comment){
            comments.Add(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder()
            


        }
    }
}