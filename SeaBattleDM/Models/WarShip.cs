using SeaBattleDM.Interfaces;


namespace SeaBattleDM.Models
{
    public class WarShip : Ship, IGun
    {
        public override string Type { get; }
        public int RangeFire { get; }

        public WarShip(int Length, int RangeFire, Direction direction, int Speed) : base(Length, direction, Speed)
        {
            Type = Types.warShip.ToString();
            this.RangeFire = RangeFire;
        }
        public override string GetState()
        {
            string result = "Ship has a \nType: " + Type + " \n Length: " + Length + "\n Speed:" + Speed + "\n Fire range: "+ RangeFire;
            return result;
        }

        public void Fire(Point point) { }
    }
    
}
