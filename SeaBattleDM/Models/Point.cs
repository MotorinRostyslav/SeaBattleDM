using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleDM.Models
{
    public struct Point
    {
        public readonly int X { get; }
        public readonly int Y { get; }
        public bool IsBlock { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            IsBlock = false;
        }
    }
}
