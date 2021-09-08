using System;
using System.Configuration;
using System.Collections.Specialized;

namespace SeaBattleDM.Models
{
    public abstract class Ship
    {
        const int MaxLengthShip = 15; //TODO: config
        public int Length { get; }
        public int Speed { get; }
        abstract public string Type { get; }
        public string Direction { get; set; }

        public Ship(int Length, Direction direction, int Speed)
        {
            Direction = direction.ToString();
            if (Length < 0 || Speed < 0) throw new ArgumentException("Don`t valid arguments. Length and speed can`t be smaller 0");

            if (Length > MaxLengthShip)
                throw new ArgumentOutOfRangeException("Exceeded the maximum size of the ship!");
            else
            {
                this.Length = Length;
                this.Speed = Speed;
            }
        }

        public virtual void Move(Direction direction) { }
        abstract public string GetState();
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

    public enum Types
    {
        warShip,
        supprotShip,
        mixedShip
    }
    public enum Direction
    {
        North,
        East,
        West,
        South
    }
}
