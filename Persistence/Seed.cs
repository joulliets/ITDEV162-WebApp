using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) 
        {
           if (context.Posts.Count() == 0)
           {
                List<Post> seedPosts = new List<Post>
                {
                    new Post() { Title = "Post One", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."},
                    new Post() { Title = "Post Two", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.."},
                    new Post() { Title = "Post Three", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.."},
                };

                context.Posts.AddRange(seedPosts);

                context.SaveChanges();
           }
        }
    }
}