using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_game
{
    class player : obj
    {
        public int speed { get; private set; }
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
            this.speed = 10;
            this.is_alive = true;
            this.health = 10000;
            this.is_solid = true;

            PB.Size = new System.Drawing.Size(this.size_X, this.size_Y);
            PB.Location = new System.Drawing.Point(this.X, this.Y);
            PB.BackColor = System.Drawing.Color.Red;
            Sword.BackColor = System.Drawing.Color.Cyan;
            Sword.Size = new System.Drawing.Size(size_X, size_Y);
        }

        public void change_X(int speed)
        {
            this.X += speed;
        }
        public void change_Y(int speed)
        {
            this.Y += speed;
        }
        public void change_hp(int hp)
        {
            this.health -= hp;
        }
        public void set_hp(int hp)
        {
            this.health = hp;
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
