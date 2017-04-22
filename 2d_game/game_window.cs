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
            map_load = new map1(map_now);
        }
        player new_player = new player();
        detect_location middle = new detect_location();
        map1 map_load;

        int map_now = 0;
        public void main(Object myObject, EventArgs myEventArgs)
        {
            for (int i = 0; i < map_load.amount_map[map_now]; i++)
            {
                for (int ii = 0; ii < map_load.map_constractor[i].Length; ii++)
                    this.Controls.Add(map_load.map_constractor[i][ii].PB);
                new_player.PB.SendToBack();
            }

            new_player.PB.BackColor = Color.Red;

            middle.fixing(new_player.X, new_player.Y, new_player.speed);

            if (Keyboard.IsKeyDown(Key.W))
            {
                if (is_touch(map_load.amount_map[map_now], new_player.speed) == -1)
                    new_player.change_Y(-new_player.speed);
                else
                    new_player.direction_movment *= 2;
            }
            if (Keyboard.IsKeyDown(Key.S))
            {
                if (is_touch(map_load.amount_map[map_now], new_player.speed) == -1)
                    new_player.change_Y(new_player.speed);
                else 
                    new_player.direction_movment *= 3;
            }
            if (Keyboard.IsKeyDown(Key.D))
            {
                if (is_touch(map_load.amount_map[map_now], new_player.speed) == -1)
                    new_player.change_X(new_player.speed);
                else
                    new_player.direction_movment *= 5;
            }
            if (Keyboard.IsKeyDown(Key.A))
            {
                if (is_touch(map_load.amount_map[map_now], new_player.speed) == -1)
                    new_player.change_X(-new_player.speed);
                else
                    new_player.direction_movment *= 7;
            }

            for (int i = 0; i < 10; i++)
            {
                place_items();
                int check = 0;
                if (is_touch(map_load.amount_map[map_now], new_player.speed) % 2 == 0)
                {
                    new_player.change_Y(new_player.speed);
                    check++;
                }
                if (is_touch(map_load.amount_map[map_now], new_player.speed) % 3 == 0)
                {
                    new_player.change_Y(-new_player.speed);
                    check++;
                }
                if (is_touch(map_load.amount_map[map_now], new_player.speed) % 5 == 0)
                {
                    new_player.change_X(-new_player.speed);
                    check++;
                }
                if (is_touch(map_load.amount_map[map_now], new_player.speed) % 7 == 0)
                {
                    new_player.change_X(new_player.speed);
                    check++;
                }
                if (check == 0)
                    new_player.direction_movment = 1;
            }
        }

        private void place_items()
        {
            new_player.PB.Left = math_staffs.VirtualSpace_to_Window_X(new_player.X, this.Width / 2, middle.X);
            new_player.PB.Top = math_staffs.VirtualSpace_to_Window_Y(new_player.Y, this.Height / 2, middle.Y);

            for (int i = 0; i < map_load.amount_map[map_now]; i++)
            {
                for (int ii = 0; ii < map_load.map_constractor[i].Length; ii++)
                {
                    map_load.map_constractor[i][ii].PB.Left = math_staffs.VirtualSpace_to_Window_X(map_load.map_constractor[i][ii].X, this.Width / 2, middle.X);
                    map_load.map_constractor[i][ii].PB.Top = math_staffs.VirtualSpace_to_Window_Y(map_load.map_constractor[i][ii].Y, this.Height / 2, middle.Y);
                }
            }
        }

        private int is_touch(int amount, int speed)
        {
            for (int i = 0; i < amount; i++)
                for (int ii = 0; ii < map_load.map_constractor[i].Length; ii++)
                    if (math_staffs.IsTouching(new_player.PB, map_load.map_constractor[i][ii].PB, new_player.direction_movment, speed) != -1 && map_load.map_constractor[i][ii].is_solid == true)
                        return math_staffs.IsTouching(new_player.PB, map_load.map_constractor[i][ii].PB, new_player.direction_movment, speed);
            return -1;
        }
    }
}
