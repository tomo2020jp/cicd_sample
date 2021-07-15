using System;
namespace cicd_sample
{
    public class Calculation
    {
        readonly int x;
        readonly int y;

        public Calculation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Add()
        {
            return x + y;
        }
    }
}
