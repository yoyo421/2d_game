using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2d_game
{
    class map1 : map
    {
        public void map1_setup()
        {
            //
            int count = 0;
            //
            map_constractor[count] = new wall().big_cube(150,300);
            //
            count++;
            //
            map_constractor[count] = new wall().custom_wall(-100,-50,90,30,true);
            //
            count++;
            //
            map_constractor[count] = new wall().custom_wall(100, -50, 90, 30, false);
            //
            count++;
            //
            map_constractor[count] = new wall().plus_big_structure(-150,300);
            //
            count++;
            //
            map_constractor[count] = new wall().cube_hollow_X_entrence_big_structure(0, -300);
            //
            count++;
            //
            map_constractor[count] = new wall().plus_big_structure(500, 500);
            //
            count++;
            //
            map_constractor[count] = new wall().cube_hollow_X_entrence_big_structure(550, 550);
        }
        public map1(int map)
        {
            map_constractor = new wall[amount_map[map]][];
            map1_setup();
        }
    }
}
