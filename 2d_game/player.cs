using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2d_game
{
    class player : obj
    {
        public int items { get; set; }
        public int direction_movment { get; set; }

        public player()
        {
            PB = new System.Windows.Forms.PictureBox();

            this.X = -5;
            this.Y = -5;
            this.size_X = 10;
            this.size_Y = 10;

            this.speed = 5;
            this.direction_movment = -1;
            this.is_alive = true;
            this.health = 100;

            PB.Size = new System.Drawing.Size(this.size_X, this.size_Y);
            PB.Location = new System.Drawing.Point(this.X, this.Y);
        }
        public void got_item(int id)
        {
            if (id == 0 && this.speed > 1)
                this.speed -= 1;
        }
    }
}
