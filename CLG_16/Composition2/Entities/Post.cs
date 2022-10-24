using System;
using System.Collections.Generic;
using System.Text;

namespace Composition2.Entities
{
    internal class Post
    {
        // The attribuits

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();  // to make sure the instantiation of the list

        // defaul constructor that don't get paramenters
        public Post()
        {
        }

        // constructor that will receive paramenters
        public Post(DateTime dateTime, string title, string content, int likes)
        {
            Moment = dateTime;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comment)
        {
            Comments.Add(comment);  // attribuits, paraments and variable 
        }
        
        public void RemoveContent(Comment comment)
        {
            Comments.Remove(comment);  // attribuits, paraments and variable 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
