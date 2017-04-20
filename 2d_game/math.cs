using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_game
{
    class math
    {
        public int VirtualSpace_to_Window_X(int VirtualSpace_x, int window_size_x)
        {
            detect_location middle_area = new detect_location();
            int returning = window_size_x - (middle_area.X - VirtualSpace_x);
            return returning;
        }

        public int VirtualSpace_to_Window_Y(int VirtualSpace_y, int window_size_y)
        {
            detect_location middle_area = new detect_location();
            int returning = window_size_y - (middle_area.Y - VirtualSpace_y);
            return returning;
        }
    }
}
