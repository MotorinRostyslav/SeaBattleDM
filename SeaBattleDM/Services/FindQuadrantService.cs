using SeaBattleDM.Models;

namespace SeaBattleDM.Services
{
    class FindQuadrantService
    {
        public static int FindQuadrant(Point[] position)
        {
            int midX = 0;
            int midY = 0;

            foreach (var i in position)
            {
                midX += i.X;
                midY += i.Y;
            }

            midX = midX / position.Length;
            midY = midY / position.Length;

            if (midX >= 0 && midY > 0)
            {
                return 1;
            }
            if (midX < 0 && midY >= 0)
            {
                return 2;
            }
            if (midX <= 0 && midY < 0)
            {
                return 3;
            }
            if (midX >= 0 && midY <= 0)
            {
                return 4;
            }
            return 0;
        }
    }
}
