using System;
using System.Collections.Generic;
using System.Text;

namespace Course.StringBuilderTask.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment() { }

        public Comment(string txt)
        {
            this.Text = txt;
        }
    }
}
