using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _2d_game
{
    public partial class game_window : Form
    {
        math math_staffs = new math();

        public game_window()
        {
            Timer myTimer = new Timer();
            InitializeComponent();
            myTimer.Tick += new EventHandler(main);
            myTimer.Interval = 20;
            myTimer.Start();
            this.Controls.Add(new_player.PB);
            this.Controls.Add(walls.PB);
        }
        player new_player = new player();
        wall walls = new wall();
        public void main(Object myObject, EventArgs myEventArgs)
        {
            new_player.PB.BackColor = Color.Red;
            new_player.PB.Left = math_staffs.VirtualSpace_to_Window_X(new_player.X, this.Width / 2);
            new_player.PB.Top = math_staffs.VirtualSpace_to_Window_Y(new_player.Y, this.Height / 2);
            if (Keyboard.IsKeyDown(Key.W))
            {
                new_player.direction_movment = 0;
                if (!IsTouching(new_player.PB, walls.PB, new_player.direction_movment))
                    new_player.Y -= new_player.speed;
            }
            if (Keyboard.IsKeyDown(Key.S))
            {
                new_player.direction_movment = 1;
                if (!IsTouching(new_player.PB, walls.PB, new_player.direction_movment))
                    new_player.Y += new_player.speed;
            }
            if (Keyboard.IsKeyDown(Key.D))
            {
                new_player.direction_movment = 2;
                if (!IsTouching(new_player.PB, walls.PB, new_player.direction_movment))
                    new_player.X += new_player.speed;
            }
            if (Keyboard.IsKeyDown(Key.A))
            {
                new_player.direction_movment = 3;
                if (!IsTouching(new_player.PB, walls.PB, new_player.direction_movment))
                    new_player.X -= new_player.speed;
            }
            if (!IsTouching(new_player.PB, walls.PB, new_player.direction_movment)) { }
        }

        private bool IsTouching(PictureBox p1, PictureBox p2, int fix_stuck)
        {
            if (p1.Location.X + p1.Width < p2.Location.X)
            {
                return false;
            }
            if (p2.Location.X + p2.Width < p1.Location.X)
            {
                return false;
            }
            if (p1.Location.Y + p1.Height < p2.Location.Y)
            {
                return false;
            }
            if (p2.Location.Y + p2.Height < p1.Location.Y)
            {
                return false;
            }
            /////////////////////////////////////////////
            if (fix_stuck == 0)
            {
                new_player.Y += 1;
            }
            if (fix_stuck == 1)
            {
                new_player.Y -= 1;
            }
            if (fix_stuck == 2)
            {
                new_player.X -= 1;
            }
            if (fix_stuck == 3)
            {
                new_player.X += 1;
            }
            fix_stuck = -1;
            return true;
        }
    }
}
