using System;

namespace Domain 
{

    public class Post
    {
        public Guid Id { get; set; }

        public String Title { get; set; }

        public String Body { get; set; }

        public DateTime Date { get; set; }
        
    }
}