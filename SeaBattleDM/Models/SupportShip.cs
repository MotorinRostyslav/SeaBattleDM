using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaBattleDM.Interfaces;

namespace SeaBattleDM.Models
{
    class SupportShip : Ship, IRepair
    {
        public override string Type { get; }
        public int RangeRepair { get; }


        public SupportShip(int Length, int RangeRepair, Direction direction, int Speed) : base(Length, direction, Speed)
        {
            Type = Types.supprotShip.ToString();
            this.RangeRepair = RangeRepair;
        }
        public override string GetState()
        {
            string result = "Ship has a \nType: " + Type + " \n Length: " + Length + "\n Speed:" + Speed + "\n Repair range: " + RangeRepair;
            return result;
        }

        public void Repairs(Point point) { }
        
    }
}
