using SeaBattleDM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleDM.Interfaces
{
    interface IGun
    {
        public int rangeFire { get; set; }
        public void Fire(Point point);
    }
}
