using SeaBattleDM.Interfaces;

namespace SeaBattleDM.Models
{
    class MixedShip : Ship, IRepair, IGun
    {
        public override string Type { get; }
        public int RangeFire { get; }
        public int RangeRepair { get; }

        public MixedShip(int Length, int RangeRepair,int RangeFire, Direction direction, int Speed) : base(Length, direction, Speed)
        {
            Type = Types.mixedShip.ToString();
            this.RangeRepair = RangeRepair;
            this.RangeFire = RangeFire;
        }
        public override string GetState()
        {
            string result = "Ship has a: \n Type: " + Type + " \n Length: " + Length + "\n Speed:" + Speed + "\n Repair range: " + RangeRepair + "\n Fire range: " + RangeFire;
            return result;
        }
        public void Fire(Point point) { }
        public void Repairs(Point point) { }
    }
}
