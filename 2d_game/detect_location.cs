using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_game
{
    class detect_location : grid__xy
    {
        public detect_location()
        {
            this.X = 0;
            this.Y = 0;
        }
        public void fixing(int x, int y, int speed)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
