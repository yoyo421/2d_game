using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2d_game
{
    class map1 : map
    {
        public void map1_setup()
        {
            int count = 0;
            bool skip = false;
            string line;

            // Read the file and display it line by line.
            using (StreamReader file = new System.IO.StreamReader(@"C:\Users\user10\Desktop\2d_game\2d_game\data\new  1.txt"))
            {
                while ((line = file.ReadLine()) != null && skip == false)
                {
                    if (line.IndexOf("::", 0) == 0)
                    {
                    }
                    else if (line.Contains("wall()") == true)
                    {
                        string[] data = line.Split('(');
                        string[] stats = data[2].Substring(0, data[2].Length - 1).Split(',');
                        if (line.Contains("cons_") == true)
                        {
                            if (line.Contains("custom_wall") == true)
                            {
                                map_constractor[count] = new wall().cons_custom_wall(int.Parse(stats[0]), int.Parse(stats[1]), int.Parse(stats[2]), int.Parse(stats[3]));
                            }
                            else if (line.Contains("plus_big_structure") == true)
                            {
                                map_constractor[count] = new wall().cons_plus_big_structure(int.Parse(stats[0]), int.Parse(stats[1]));
                            }
                            else if (line.Contains("cube_hollow_X_entrence_big_structure") == true)
                            {
                                map_constractor[count] = new wall().cons_cube_hollow_X_entrence_big_structure(int.Parse(stats[0]), int.Parse(stats[1]));
                            }
                            else if (line.Contains("five_cubes_X_big_structure") == true)
                            {
                                map_constractor[count] = new wall().cons_five_cubes_X_big_structure(int.Parse(stats[0]), int.Parse(stats[1]));
                            }
                            else if (line.Contains("smily_face_big_structure") == true)
                            {
                                map_constractor[count] = new wall().cons_smily_face_big_structure(int.Parse(stats[0]), int.Parse(stats[1]));
                            }
                        }
                        else if (line.Contains("multi_") == true)
                        {
                            if (line.Contains("set_solid") == true)
                            {
                                map_constractor[count] = new wall().multi_set_solid(map_constractor[count], Parse(stats[1]));
                            }
                            else if (line.Contains("set_backround") == true)
                            {
                                map_constractor[count] = new wall().multi_set_backround(map_constractor[count], Parse(stats[1]));
                            }
                            else if (line.Contains("set_image") == true)
                            {
                                map_constractor[count] = new wall().multi_set_image(map_constractor[count], stats[1].Substring(1, stats[1].Length - 2));
                            }
                            else if (line.Contains("set_color") == true)
                            {
                                map_constractor[count] = new wall().multi_set_color(map_constractor[count], color(stats[1]));
                            }
                        }
                        else if (line.Contains("solo_") == true)
                        {
                            if (line.Contains("set_solid") == true)
                            {
                                map_constractor[count] = new wall().solo_set_solid(map_constractor[count], Parse(stats[1]), int.Parse(stats[2]));
                            }
                            else if (line.Contains("set_backround") == true)
                            {
                                map_constractor[count] = new wall().solo_set_backround(map_constractor[count], Parse(stats[1]), int.Parse(stats[2]));
                            }
                            else if (line.Contains("set_image") == true)
                            {
                                map_constractor[count] = new wall().solo_set_image(map_constractor[count], stats[1].Substring(1, stats[1].Length - 2), int.Parse(stats[2]));
                            }
                            else if (line.Contains("set_color") == true)
                            {
                                map_constractor[count] = new wall().solo_set_color(map_constractor[count], color(stats[1]), int.Parse(stats[2]));
                            }
                        }
                        else if (line.Contains("convert_") == true)
                        {
                            if (line.Contains("trap_to_wall") == true)
                            {
                                if (line.Contains("trap()."))
                                {
                                    if (line.Contains("custom_wall") == true)
                                    {
                                        map_constractor[count] = new wall().convert_trap_to_wall(new trap().cons_custom_wall(int.Parse(stats[0]), int.Parse(stats[1]), int.Parse(stats[2]), int.Parse(stats[3])));
                                    }
                                }
                            }
                        }
                    }
                    if (line == "!" && skip == false)
                        count++;
                    if (line == "Ω")
                        skip = true;
                }
            }

            //map_constractor[count] = new wall().cons_custom_wall(-100,-50,90,30);
            //count++;
            //map_constractor[count] = new wall().cons_custom_wall(100, -50, 90, 30);

            //map_constractor[count] = new wall().multi_set_solid(map_constractor[count], false);
            //map_constractor[count] = new wall().multi_set_backround(map_constractor[count], true);
            
            //count++;
            //map_constractor[count] = new wall().cons_plus_big_structure(-150,300);
            //count++;
            //map_constractor[count] = new wall().cons_cube_hollow_X_entrence_big_structure(0, -300);
            //count++;
            //map_constractor[count] = new wall().cons_plus_big_structure(500, 500);
            //count++;
            //map_constractor[count] = new wall().cons_cube_hollow_X_entrence_big_structure(550, 550);
            //count++;
            //map_constractor[count] = new wall().cons_five_cubes_X_big_structure(-300, 100);
            //count++;
            //map_constractor[count] = new wall().cons_five_cubes_X_big_structure(-150, -300);

            //map_constractor[count] = new wall().solo_set_image(map_constractor[count],"https://i.ytimg.com/vi/h-cmvEFE7-E/hqdefault.jpg?custom=true&w=168&h=94&stc=true&jpg444=true&jpgq=90&sp=67&sigh=d3bmrUp0-Ea3CjdP0RDTAEbXfbU", 2);
            
            //count++;
            //map_constractor[count] = new wall().cons_smily_face_big_structure(-500, -500);
            //count++;
            //map_constractor[count] = new wall().convert_trap_to_wall(new trap().cons_big_cube(300, 0));
        }
        public map1(int map)
        {
            amount_map[0] = 9;
            map_constractor = new wall[amount_map[map]][];
            map1_setup();
            map_minimap = new wall[amount_map[map]][];
            for (int i = 0; i < amount_map[map]; i++)
            {
                //map_minimap[i] = wall.copy(map_constractor[i]);
                map_minimap[i] = new wall().size_change(map_minimap[i], 50);
                map_minimap[i] = new wall().multi_set_solid(map_minimap[i], true);
            }
        }

        private bool Parse(string x)
        {
            if (x.ToLower().Contains("true") == true)
                return true;
            return false;
        }
        private System.Drawing.Color color(string x)
        {
            System.Drawing.Color clr = new System.Drawing.Color();
            if (x.ToLower().Contains("red") == true)
                clr = System.Drawing.Color.Red;
            else if (x.ToLower().Contains("green") == true)
                clr = System.Drawing.Color.Green;
            else if (x.ToLower().Contains("blue") == true)
                clr = System.Drawing.Color.Blue;
            else if (x.ToLower().Contains("yellow") == true)
                clr = System.Drawing.Color.Yellow;
            else
            {
                string[] stats = x.Split('|');
                clr = System.Drawing.Color.FromArgb(int.Parse(stats[0]), int.Parse(stats[1]), int.Parse(stats[2]));
            }
            return clr;
        }
    }
}
