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
            this.is_backround = false;

            this.PB.BackColor = Color.Black;
        }
        //cons
        public wall[] cons_big_cube(int x, int y)
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
        public wall[] cons_custom_wall(int x, int y, int size_x, int size_y)
        {
            wall[] tample = new wall[1];
            tample[0] = new wall();
            tample[0].X = x;
            tample[0].Y = y;
            tample[0].size_X = size_x;
            tample[0].size_Y = size_y;
            tample[0].PB.Size = new Size(tample[0].size_X, tample[0].size_Y);
            tample[0].PB.Location = new Point(tample[0].X, tample[0].Y);
            return tample;
        }
        public wall[] cons_plus_big_structure(int x, int y)
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
        public wall[] cons_cube_hollow_X_entrence_big_structure(int x, int y)
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
        public wall[] cons_five_cubes_X_big_structure(int x, int y)
        {
            wall[] tample = new wall[5];
            int i = 0;

            tample[i] = new wall();
            tample[i].X = x;
            tample[i].Y = y;
            tample[i].size_X = 50;
            tample[i].size_Y = 50;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 150;
            tample[i].Y = y;
            tample[i].size_X = 50;
            tample[i].size_Y = 50;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 75;
            tample[i].Y = y + 75;
            tample[i].size_X = 50;
            tample[i].size_Y = 50;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x;
            tample[i].Y = y + 150;
            tample[i].size_X = 50;
            tample[i].size_Y = 50;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            i++;
            tample[i] = new wall();
            tample[i].X = x + 150;
            tample[i].Y = y + 150;
            tample[i].size_X = 50;
            tample[i].size_Y = 50;
            tample[i].PB.Size = new Size(tample[i].size_X, tample[i].size_Y);
            tample[i].PB.Location = new Point(tample[i].X, tample[i].Y);
            return tample;
        }
        //multi
        public wall[] multi_set_solid(wall[] obj_wall, bool solid)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                tample[i].is_solid = solid;
            }
            return tample;
        }
        public wall[] multi_set_backround(wall[] obj_wall, bool backround)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                tample[i].is_backround = backround;
            }
            return tample;
        }
        public wall[] multi_set_image(wall[] obj_wall, string url)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                tample[i].PB.Load(url);
                tample[i].PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            }
            return tample;
        }
        public wall[] multi_set_color(wall[] obj_wall, Color clr)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                tample[i].PB.BackColor = clr;
            }
            return tample;
        }
        //solo
        public wall[] solo_set_solid(wall[] obj_wall, bool solid, int place)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                if (i == place)
                    tample[i].is_solid = solid;
            }
            return tample;
        }
        public wall[] solo_set_backround(wall[] obj_wall, bool backround, int place)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                if (i == place)
                    tample[i].is_backround = backround;
            }
            return tample;
        }
        public wall[] solo_set_image(wall[] obj_wall, string url, int place)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                if (i == place)
                {
                    tample[i].PB.Load(url);
                    tample[i].PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
                }
            }
            return tample;
        }
        public wall[] solo_set_color(wall[] obj_wall, Color clr, int place)
        {
            wall[] tample = new wall[obj_wall.Length];
            for (int i = 0; i < obj_wall.Length; i++)
            {
                tample[i] = obj_wall[i];
                if (i == place)
                    tample[i].PB.BackColor = clr;
            }
            return tample;
        }
    }
}
