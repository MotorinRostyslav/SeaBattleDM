using SeaBattleDM.Services;
using System;

namespace SeaBattleDM.Models
{
    public class Map
    {
        const int MaxSizeMap = 10;
        public Point[][] Points { get; }
        public Quadrant[] Quadrants { get; }
        public CollectionShips Ships { get; set; }

        public Map()
        {
            Ships = new CollectionShips();
            Quadrants = new Quadrant[4];
            Points = new Point[MaxSizeMap][];
            FillingMap();
        }
        public void AddShip(Ship ship, Point[] position)
        {
            if(PositionService.CheckFreePosition(position) == true)
            {
                int QuadrantId = FindQuadrantService.FindQuadrant(position);
                WrapperShip wrapperShip = new WrapperShip(ship, position, QuadrantId);
                Ships.Add(wrapperShip);
                PositionService.LockPoint(position);
            }
            else
            {
                throw new ArgumentException("One of these positions is blocked!");
            }
        }
        public string GetState()
        {
            string result = "";
            var templateShip = Ships;
            Ships = new CollectionShips();
            Ships.Add(templateShip.ShipsSort());

            result += "Map`s state include a: \n Size: " + MaxSizeMap + "\n Bottom left and top right points: "
                + Points[0][0].X+":"+ Points[0][0].Y + " , " + Points[MaxSizeMap-1][MaxSizeMap-1].X +":"+ Points[MaxSizeMap - 1][MaxSizeMap - 1].Y;

            for (int i = 0; i < Ships.wrapperShips.Count; i++)
            {
                result += "\nHave a next ship [ "+ "Ship type: "+Ships.wrapperShips[i].Ship.Type
                    + " Ship length: " + Ships.wrapperShips[i].Ship.Length + " Ship speed: " + Ships.wrapperShips[i].Ship.Length
                    +" Ship`s quadrant: "+ Ships.wrapperShips[i].QuadrantId + " ]";
            }

            return result;
        }
        private void FillingMap()
        {
            int halfSizeMap = MaxSizeMap / 2;

            int l = 0;
            for (int i = halfSizeMap - MaxSizeMap; i < halfSizeMap; i++, l++)
            {
                Points[l] = new Point[MaxSizeMap];
                int k = 0;
                for (int j = halfSizeMap - MaxSizeMap; j < halfSizeMap; j++, k++)
                {
                    Points[l][k] = new Point(j, i);
                }
            }

            for (int i = 1; i < 5; i++)
            {
                Quadrant quadrant = new Quadrant(i);
                Quadrants[i - 1] = quadrant;
            }
        }
    }
}
