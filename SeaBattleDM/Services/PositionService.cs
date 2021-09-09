using SeaBattleDM.Models;


namespace SeaBattleDM.Services
{
    class PositionService
    {
        public static void LockPoint(Point[] position)
        {
            for (int i = 0; i < position.Length; i++)
            {
                position[i].IsBlock = true;
            }
        }
        public static bool CheckFreePosition(Point[] position)
        {
            bool checker = true;
            foreach (var point in position)
            {
                if (point.IsBlock == true) checker = false;
            }
            return checker;
        }
    }
}
