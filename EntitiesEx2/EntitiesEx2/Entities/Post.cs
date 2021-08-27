using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Post
    {
        public string Titulo { get; set; }
        public DateTime Moment { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(string titulo, DateTime moment, string content, int likes)
        {
            Titulo = titulo;
            Moment = moment;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Curtidas - ");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("\n"+Content +"\n");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
