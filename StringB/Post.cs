using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;

namespace Curso{
    class Post{
        public DateTime Moment{get; set;}
        public string Title{get; set;}
        public string Content{get; set;}
        public int Likes {get; set;}

        public List<Comment> comments {get; set;} = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes){
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddCommnet(Comment comment){
            comments.Add(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append($"{Likes.ToString()} lIKES - ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Content);
            sb.AppendLine("Comment: ");
            foreach(Comment comment in comments){
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();

        }
    }
}