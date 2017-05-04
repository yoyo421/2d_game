using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2d_game
{
    class trap : obj
    {
        //it's a trap!, made in may the 4 be with you
        public trap()
        {
            PB = new System.Windows.Forms.PictureBox();

            this.is_alive = true;
            this.health = 10000;
            this.is_solid = false;
            this.is_invincible = true;
            this.is_backround = true;
            this.is_attack = true;
            this.dmg = 100;

            this.PB.BackColor = System.Drawing.Color.Brown;
        }
        public trap[] cons_big_cube(int x, int y)
        {
            trap[] tample = new trap[1];
            tample[0] = new trap();
            tample[0].X = x;
            tample[0].Y = y;
            tample[0].size_X = 100;
            tample[0].size_Y = 100;
            tample[0].PB.Size = new Size(tample[0].size_X, tample[0].size_Y);
            tample[0].PB.Location = new Point(tample[0].X, tample[0].Y);
            return tample;
        }
    }
}
