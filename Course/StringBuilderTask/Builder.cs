using System;
using System.Collections.Generic;
using System.Text;
using Course.StringBuilderTask.Entities;

namespace Course.StringBuilderTask
{
    class Builder
    {
        public Builder()
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("2018-06-21 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("2018-07-28 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                12
            );

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p2);
        }
    }
}
