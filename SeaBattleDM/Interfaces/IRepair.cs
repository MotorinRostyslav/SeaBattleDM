using SeaBattleDM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleDM.Interfaces
{
    interface IRepair
    {
        public int RangeRepair { get; }
        public void Repairs(Point point);
    }
}
