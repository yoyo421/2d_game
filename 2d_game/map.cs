using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_game
{
    class map
    {
        public wall[][] map_constractor { get; protected set; }
        public int[] amount_map { get; protected set; }  = new int[] { 7 , 0 };
        public bool is_finish = false;
    }
}
