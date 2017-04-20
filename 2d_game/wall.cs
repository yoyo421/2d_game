using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2d_game
{
    class wall : obj
    {
        public wall()
        {
            PB = new System.Windows.Forms.PictureBox();

            this.X = 30;
            this.Y = 30;
            this.size_X = 30;
            this.size_Y = 50;

            this.is_alive = true;
            this.health = 100;
            this.is_solid = true;
            this.is_invincible = true;

            this.PB.BackColor = Color.Black;
            PB.Size = new System.Drawing.Size(this.size_X, this.size_Y);
            PB.Location = new System.Drawing.Point(this.X, this.Y);
        }
    }
}
