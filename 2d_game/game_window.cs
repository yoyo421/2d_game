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
            Timer myTimer1 = new Timer();
            Timer myTimer2 = new Timer();
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

        private void up_and_down()
        {
            if (Keyboard.IsKeyDown(Key.W))
            {
                    new_player.change_Y(-new_player.speed);
                    new_player.direction_movment *= 2;
            }
            if (Keyboard.IsKeyDown(Key.S))
            {
                    new_player.change_Y(new_player.speed);
                    new_player.direction_movment *= 3;
            }
        }
        private void left_and_right()
        {
            if (Keyboard.IsKeyDown(Key.D))
            {
                    new_player.change_X(new_player.speed);
                    new_player.direction_movment *= 5;
            }
            if (Keyboard.IsKeyDown(Key.A))
            {
                    new_player.change_X(-new_player.speed);
                    new_player.direction_movment *= 7;
            }
        }

        private void up_and_down(player p1)
        {
            if (Keyboard.IsKeyDown(Key.W))
            {
                p1.direction_movment *= 2;
            }
            if (Keyboard.IsKeyDown(Key.S))
            {
                p1.direction_movment *= 3;
            }
        }
        private void left_and_right(player p1)
        {
            if (Keyboard.IsKeyDown(Key.D))
            {
                p1.direction_movment *= 5;
            }
            if (Keyboard.IsKeyDown(Key.A))
            {
                p1.direction_movment *= 7;
            }
        }

        int map_now = 0;
        public void main(object sender, EventArgs e)
        {
            for (int i = 0; i < map_load.amount_map[map_now]; i++)
            {
                for (int ii = 0; ii < map_load.map_constractor[i].Length; ii++)
                {
                    this.Controls.Add(map_load.map_constractor[i][ii].PB);
                    if (map_load.map_constractor[i][ii].is_backround == false)
                        map_load.map_constractor[i][ii].PB.BringToFront();
                    if (map_load.map_constractor[i][ii].is_backround == true)
                        map_load.map_constractor[i][ii].PB.SendToBack();
                }
            }

            left_and_right();
            up_and_down();

            if (true)
            {
                player p1 = new_player.set_player(new_player);
                for (int i = 0; i < 5; i++)
                {
                    if (Keyboard.IsKeyDown(Key.Space))
                    {

                    }
                    int check = 0, Is_touth = is_touch(map_load.amount_map[map_now], p1.speed, p1);
                    if (Is_touth % 2 == 0)
                    {
                        p1.change_Y(-p1.speed);
                        check++;
                    }
                    if (Is_touth % 3 == 0)
                    {
                        p1.change_Y(p1.speed);
                        check++;
                    }
                    if (Is_touth % 5 == 0)
                    {
                        p1.change_X(p1.speed);
                        check++;
                    }
                    if (Is_touth % 7 == 0)
                    {
                        p1.change_X(-p1.speed);
                        check++;
                    }
                    p1.direction_movment = 1;
                }
                new_player.set_xy(p1.X, p1.Y);
            }
            place_items();
        }

        private void place_items()
        {
            new_player.PB.Left = math_staffs.VirtualSpace_to_Window_X(new_player.X, this.Width / 2, middle.X);
            new_player.PB.Top = math_staffs.VirtualSpace_to_Window_Y(new_player.Y, this.Height / 2, middle.Y);
            middle.fixing(new_player.X, new_player.Y);

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
            int returned = 1;
            for (int i = 0; i < amount; i++)
                for (int ii = 0; ii < map_load.map_constractor[i].Length; ii++)
                    if (math_staffs.IsTouching(
                        new_player.X,
                        new_player.Y,
                        map_load.map_constractor[i][ii].X,
                        map_load.map_constractor[i][ii].Y,
                        new_player.size_X,
                        new_player.size_Y,
                        map_load.map_constractor[i][ii].size_X,
                        map_load.map_constractor[i][ii].size_Y,
                        new_player.direction_movment, speed) != -1 &&
                        map_load.map_constractor[i][ii].is_solid == true)
                        returned *= (math_staffs.IsTouching(
                        new_player.X,
                        new_player.Y,
                        map_load.map_constractor[i][ii].X,
                        map_load.map_constractor[i][ii].Y,
                        new_player.size_X,
                        new_player.size_Y,
                        map_load.map_constractor[i][ii].size_X,
                        map_load.map_constractor[i][ii].size_Y,
                        new_player.direction_movment, speed));
            if (returned == 1)
                returned = -1;
            return returned;
        }
        private int is_touch(int amount, int speed, player p1)
        {
            int returned = 1;
            for (int i = 0; i < amount; i++)
                for (int ii = 0; ii < map_load.map_constractor[i].Length; ii++)
                    if (math_staffs.IsTouching(
                        p1.X,
                        p1.Y,
                        map_load.map_constractor[i][ii].X,
                        map_load.map_constractor[i][ii].Y,
                        p1.size_X,
                        p1.size_Y,
                        map_load.map_constractor[i][ii].size_X,
                        map_load.map_constractor[i][ii].size_Y,
                        p1.direction_movment, speed) != -1 &&
                        map_load.map_constractor[i][ii].is_solid == true)
                        returned *= (math_staffs.IsTouching(
                        p1.X,
                        p1.Y,
                        map_load.map_constractor[i][ii].X,
                        map_load.map_constractor[i][ii].Y,
                        p1.size_X,
                        p1.size_Y,
                        map_load.map_constractor[i][ii].size_X,
                        map_load.map_constractor[i][ii].size_Y,
                        p1.direction_movment, speed));
            if (returned == 1)
                returned = -1;
            return returned;
        }
    }
}
