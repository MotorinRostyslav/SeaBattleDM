using System;
using System.Collections.Generic;

namespace SeaBattleDM.Models
{
    public class CollectionShips
    {
        public List<WrapperShip> wrapperShips = new List<WrapperShip>();
        public void Add(WrapperShip ship)
        {
            wrapperShips.Add(ship);
        }
        public void Add(List<WrapperShip> ships)
        {
            foreach (var i in ships)
            {
                wrapperShips.Add(i);
            }
        }
        public List<WrapperShip> ShipsSort()
        {
            wrapperShips.Sort(new WrapperShipComparer());
            return wrapperShips;
        }
        public WrapperShip this[int quadrantId, int X, int Y]
        {
            get
            {
                for (int i = 0; i < wrapperShips.Count; i++)
                {
                    for (int j = 0; j < wrapperShips[i].Position.Length; j++)
                    {
                        if (X == Math.Abs(wrapperShips[i].Position[j].X) && Y == Math.Abs(wrapperShips[i].Position[j].Y) && quadrantId == wrapperShips[i].QuadrantId)
                        {
                            return wrapperShips[i];
                        }
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < wrapperShips.Count; i++)
                {
                    for (int j = 0; j < wrapperShips[i].Position.Length; j++)
                    {
                        if (X == Math.Abs(wrapperShips[i].Position[j].X) && Y == Math.Abs(wrapperShips[i].Position[j].Y) && quadrantId == wrapperShips[i].QuadrantId)
                        {
                            wrapperShips[i] = value;
                        }
                    }
                }
            }
        }
    }
}
