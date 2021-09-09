using SeaBattleDM.Models;

namespace SeaBattleDM.Services
{
    class FindQuadrantService
    {
        public static int FindQuadrant(Point[] position)
        {
            int averageX = 0;
            int averageY = 0;

            foreach (var i in position)
            {
                averageX += i.X;
                averageY += i.Y;
            }

            averageX = averageX / position.Length;
            averageY = averageY / position.Length;

            if (averageX >= 0 && averageY > 0)
            {
                return 1;
            }
            if (averageX < 0 && averageY >= 0)
            {
                return 2;
            }
            if (averageX <= 0 && averageY < 0)
            {
                return 3;
            }
            if (averageX >= 0 && averageY <= 0)
            {
                return 4;
            }
            return 0;
        }
    }
}
