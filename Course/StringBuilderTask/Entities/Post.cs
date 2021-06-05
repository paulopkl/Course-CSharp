using System;
using System.Collections.Generic;
using System.Text;

namespace Course.StringBuilderTask.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> comment { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            this.comment.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            this.comment.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Title);
            sb.Append(this.Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(this.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("I'm going to visit this wonderful country!");
            sb.AppendLine("Comments:");
            sb.AppendLine("Have a nice trip");
            sb.AppendLine("Wow that's awesome!");

            return sb.ToString();
        }
    }
}
