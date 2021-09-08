using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleDM.Models
{
    abstract class Ship
    {
        abstract public int Length { get; }
        abstract public int Speed { get; }
        abstract public string Type { get; }
        abstract public string Direction { get; set; }
        public virtual void Move(string direction) { }
        abstract public  void GetState();
        public static bool operator ==(Ship ship1, Ship ship2)
        {
            if(ship1.Length == ship2.Length && ship1.Speed == ship2.Speed && ship1.Type == ship2.Type)
                return true;
            else return false;
        }
        public static bool operator !=(Ship ship1, Ship ship2)
        {
            if (ship1.Length == ship2.Length && ship1.Speed == ship2.Speed && ship1.Type == ship2.Type)
                return false;
            else return true;
        }
    }
}
