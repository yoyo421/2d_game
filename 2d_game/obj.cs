using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2d_game
{
    class obj : grid__xy
    {
        public PictureBox PB { get; protected set; }

        public int size_X { get; protected set; }
        public int size_Y { get; protected set; }

        public bool is_solid { get; protected set; }
        public bool is_alive { get; protected set; }
        public bool is_attack { get; protected set; }
        public bool is_invincible { get; protected set; }
        public bool is_backround { get; protected set; } //aka invisible
        public int health { get; protected set; }
        public int dmg { get; protected set; }
    }
}
