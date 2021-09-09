using SeaBattleDM.Models;


namespace SeaBattleDM.Interfaces
{
    public interface IRepair
    {
        public int RangeRepair { get; }
        public void Repairs(Point point);
    }
}
