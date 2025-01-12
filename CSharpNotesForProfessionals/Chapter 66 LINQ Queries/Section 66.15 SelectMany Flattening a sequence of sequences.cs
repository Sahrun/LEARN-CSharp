using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_15
    {
        public Section_66_15()
        {
            var sequanceOfSequences = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 9 } };
            var sequence = sequanceOfSequences.SelectMany(x => x);

            Console.WriteLine("Select Many lambda : {0}", string.Join(",", sequence));

            sequence = from sub in sequanceOfSequences
                       from item in sub
                       select item;

            Console.WriteLine("Select Many LINQ : {0}", string.Join(",", sequence));

            // Exampe SelectMany from Object

            Console.WriteLine("Select Many Example");

            List<BlogPost> posts = new List<BlogPost>()
            {
                new BlogPost()
                {
                    Id = 1,
                    Comments = new List<Comment>() {
                    new Comment()
                    {
                        Id =1,
                        Content = "It's really great!"
                    },
                    new Comment()
                    {
                        Id = 2,
                        Content = "Coll Post!"
                    }
                    }
                },
                new BlogPost()
                {
                    Id =2,
                    Comments = new List<Comment>()
                    {
                    new Comment() {
                    Id = 3,
                    Content = "I don't think you're right"
                    },
                    new Comment
                    {
                        Id=4,
                        Content = "This post is a complete nonsense"
                    }

                    }
                }
            };


            var commmandsWithIds = posts.SelectMany(p => p.Comments, (post, comment) => new
            {
                PostId = post.Id,
                CommentContent = comment.Content
            });


            foreach (var post in commmandsWithIds)
            {
                Console.WriteLine("Post Id : {0} , Comment : {1}", post.PostId, post.CommentContent);
            }
        }
    }

    public class BlogPost
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
