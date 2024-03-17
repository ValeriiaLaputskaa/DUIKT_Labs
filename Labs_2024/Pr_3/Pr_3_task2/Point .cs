using Microsoft.SqlServer.Server;

namespace Pr_3.Pr_3_task2
{
    public class Point
    {
        private int x;
        private int y;
        private string pointName;

        public Point(int x, int y, string pointName)
        {
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }

        public int X 
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string PointName
        {
            get { return pointName; }
        }


    }
}