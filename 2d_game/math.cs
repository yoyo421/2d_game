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

        public int IsTouching(PictureBox p1, PictureBox p2, int fix_stuck, int speed)
        {
            if (p1.Location.X + p1.Width - speed < p2.Location.X)
            {
                return -1;
            }
            if (p2.Location.X + p2.Width - speed < p1.Location.X)
            {
                return -1;
            }
            if (p1.Location.Y + p1.Height - speed < p2.Location.Y)
            {
                return -1;
            }
            if (p2.Location.Y + p2.Height - speed < p1.Location.Y)
            {
                return -1;
            }
            /////////////////////////////////////////////
            if (fix_stuck >= 0)
            {
                return check_detect(p1, p2, speed);
            }
            return -1;
        }
        private int check_detect(PictureBox p1, PictureBox p2, int speed)
        {
            int i = 1;
            if (p1.Location.X + p1.Width - speed > p2.Location.X)
            {
                i *= 7;
            }
            if (p2.Location.X + p2.Width - speed > p1.Location.X)
            {
                i *= 5;
            }
            if (p1.Location.Y + p1.Height - speed > p2.Location.Y)
            {
                i *= 2;
            }
            if (p2.Location.Y + p2.Height - speed > p1.Location.Y)
            {
                i *= 3;
            }
            return i;
        }
    }
}
