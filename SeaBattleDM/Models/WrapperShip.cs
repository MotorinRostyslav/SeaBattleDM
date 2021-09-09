using System;
using System.Collections.Generic;

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

            double length1 = CalculateLength(position1);
            double length2 = CalculateLength(position2);

            if (length1 > length2) return 1;
            if (length1 < length2) return -1;
            return 0;
        }
        private double CalculateLength(Point[] position)
        {
            Point zeroPoint = new Point(0, 0);
            double averageX = 0;
            double averageY = 0;

            foreach (var point in position)
            {
                averageX += point.X;
                averageY += point.Y;
            }

            averageX = averageX / position.Length;
            averageY = averageY / position.Length;

            return Math.Sqrt(Math.Pow(zeroPoint.X - averageX, 2) + Math.Pow(zeroPoint.Y - averageY, 2));
        }
    }
}
