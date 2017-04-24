using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_game
{
    class player : obj
    {
        public int direction_movment { get; set; }
        public System.Windows.Forms.PictureBox Sword { get; private set; }

        public player()
        {
            PB = new System.Windows.Forms.PictureBox();
            Sword = new System.Windows.Forms.PictureBox();

            this.X = -5;
            this.Y = -5;
            this.size_X = 20;
            this.size_Y = 20;

            this.direction_movment = 1;
            this.speed = 5;
            this.is_alive = true;
            this.health = 100;

            PB.Size = new System.Drawing.Size(this.size_X, this.size_Y);
            PB.Location = new System.Drawing.Point(this.X, this.Y);
            PB.BackColor = System.Drawing.Color.Red;
            Sword.BackColor = System.Drawing.Color.Cyan;
            Sword.Size = new System.Drawing.Size(size_X, size_Y);
        }
        public int attack(bool is_x)
        {
            int x = this.X, y = this.Y;
            if (this.direction_movment % 2 == 0)
            {
                y -= this.size_Y;
            }
            if (this.direction_movment % 3 == 0)
            {
                y += this.size_Y;
            }
            if (this.direction_movment % 5 == 0)
            {
                x += this.size_X;
            }
            if (this.direction_movment % 7 == 0)
            {
                x -= this.size_X;
            }
            if (is_x == true)
                return x;
            return y;
        }

        public void change_X(int speed)
        {
            this.X += speed;
        }
        public void change_Y(int speed)
        {
            this.Y += speed;
        }
        public void set_xy(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }
        public player set_player(player pl)
        {
            return pl;
        }
    }
}
