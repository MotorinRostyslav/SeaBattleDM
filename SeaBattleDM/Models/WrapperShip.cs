using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleDM.Models
{
    public class WrapperShip 
    {
        public Ship Ship { get; }
        public Point[] Position { get; set; }
        public int QuadrantId { get; set; }
        public WrapperShip(Ship ship, Point[] position, int quadrantId)
        {
            Ship = ship;
            Position = position;
            QuadrantId = quadrantId;
        }
       
    }
    class WrapperShipComparer : IComparer<WrapperShip>
    {
        public int Compare(WrapperShip first, WrapperShip second)
        {
            var position1 = first.Position;
            var position2 = second.Position;

            double length1 = MathLength(position1);
            double length2 = MathLength(position2);

            if (length1 > length2) return 1;
            if (length1 < length2) return -1;
            return 0;
        }
        private double MathLength(Point[] position)
        {
            Point zeroPoint = new Point(0, 0);
            double midX = 0;
            double midY = 0;

            foreach (var i in position)
            {
                midX += i.X;
                midY += i.Y;
            }

            midX = midX / position.Length;
            midY = midY / position.Length;

            return Math.Sqrt(Math.Pow(zeroPoint.X - midX, 2) + Math.Pow(zeroPoint.Y - midY, 2));
        }
    }
}
