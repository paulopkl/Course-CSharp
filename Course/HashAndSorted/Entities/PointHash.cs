using System;
using System.Collections.Generic;
using System.Text;

namespace Course.HashAndSorted.Entities
{
    struct PointHash
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointHash(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }
    }
}
