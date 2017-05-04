using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2d_game
{
    class math
    {
        public int VirtualSpace_to_Window_X(int VirtualSpace_x, int window_size_x, int middle_x)
        {
            int returning = window_size_x - (middle_x - VirtualSpace_x);
            return returning;
        }

        public int VirtualSpace_to_Window_Y(int VirtualSpace_y, int window_size_y, int middle_y)
        {
            int returning = window_size_y - (middle_y - VirtualSpace_y);
            return returning;
        }

        public int IsTouching(int x1, int y1, int x2, int y2, int size_x1, int size_y1, int size_x2, int size_y2, int fix_stuck, int speed)
        {
            if (x1 + size_x1 - 1 < x2)
            {
                return -1;
            }
            if (x2 + size_x2 - 1 < x1)
            {
                return -1;
            }
            if (y1 + size_y1 - 1 < y2)
            {
                return -1;
            }
            if (y2 + size_y2 - 1 < y1)
            {
                return -1;
            }
            /////////////////////////////////////////////
            if (fix_stuck >= 0)
            {
                return check_detect(x1, y1, x2, y2, size_x1, size_y1, size_x2, size_y2, speed);
            }
            return -1;
        }
        private int check_detect(int x1, int y1, int x2, int y2, int size_x1, int size_y1, int size_x2, int size_y2, int speed)
        {
            int i = 210;
            if (x1 + size_x1 - speed - 1 > x2)
            {
                i /= 7;
            }
            if (x2 + size_x2 - speed - 1 > x1)
            {
                i /= 5;
            }
            if (y1 + size_y1 - speed - 1 > y2)
            {
                i /= 2;
            }
            if (y2 + size_y2 - speed - 1 > y1)
            {
                i /= 3;
            }
            return i;
        }
    }
}
