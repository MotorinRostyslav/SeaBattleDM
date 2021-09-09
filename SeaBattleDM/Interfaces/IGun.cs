using SeaBattleDM.Models;

namespace SeaBattleDM.Interfaces
{
    public interface IGun
    {
        public int RangeFire { get; }
        public void Fire(Point point);
    }
}
