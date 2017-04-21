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

            this.is_alive = true;
            this.health = 100;
            this.is_solid = true;
            this.is_invincible = true;

            this.PB.BackColor = Color.Black;
        }
        public wall[] big_cube(int x, int y)
        {
            wall[] tample = new wall[1];
            tample[0] = new wall();
            tample[0].X = x;
            tample[0].Y = y;
            tample[0].size_X = 100;
            tample[0].size_Y = 100;
            tample[0].PB.Size = new Size(tample[0].size_X, tample[0].size_Y);
            tample[0].PB.Location = new Point(tample[0].X, tample[0].Y);
            return tample;
        }
        public wall[] custom_wall(int x, int y, int size_x, int size_y, bool solid)
        {
            wall[] tample = new wall[1];
            tample[0] = new wall();
            tample[0].X = x;
            tample[0].Y = y;
            tample[0].size_X = size_x;
            tample[0].size_Y = size_y;
            tample[0].PB.Size = new Size(tample[0].size_X, tample[0].size_Y);
            tample[0].PB.Location = new Point(tample[0].X, tample[0].Y);
            tample[0].is_solid = solid;
            return tample;
        }
        public wall[] plus_big_structure(int x, int y)
        {
            wall[] tample = new wall[4];
            int i = 0;

            tample[i] = new wall();
            tample[i].X = x;
            tample[i].Y = y + 150;
            tample[i].size_X = 100;
            tample[i].size_Y = 20;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 150;
            tample[i].Y = y;
            tample[i].size_X = 20;
            tample[i].size_Y = 100;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 220;
            tample[i].Y = y + 150;
            tample[i].size_X = 100;
            tample[i].size_Y = 20;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 150;
            tample[i].Y = y + 220;
            tample[i].size_X = 20;
            tample[i].size_Y = 100;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            return tample;
        }
        public wall[] cube_hollow_X_entrence_big_structure(int x, int y)
        {
            wall[] tample = new wall[4];
            int i = 0;

            tample[i] = new wall();
            tample[i].X = x + 60;
            tample[i].Y = y;
            tample[i].size_X = 100;
            tample[i].size_Y = 20;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 200;
            tample[i].Y = y + 60;
            tample[i].size_X = 20;
            tample[i].size_Y = 100;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x;
            tample[i].Y = y + 60;
            tample[i].size_X = 20;
            tample[i].size_Y = 100;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 60;
            tample[i].Y = y + 200;
            tample[i].size_X = 100;
            tample[i].size_Y = 20;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            return tample;
        }
    }
}
