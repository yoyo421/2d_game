using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_game
{
    class map1 : map
    {
        public void map1_setup()
        {
            int count = 0;
            map_constractor[count] = new wall().cons_custom_wall(-100,-50,90,30);
            count++;
            map_constractor[count] = new wall().cons_custom_wall(100, -50, 90, 30);
            map_constractor[count] = new wall().multi_set_solid(map_constractor[count], false);
            map_constractor[count] = new wall().multi_set_backround(map_constractor[count], true);
            count++;
            map_constractor[count] = new wall().cons_plus_big_structure(-150,300);
            count++;
            map_constractor[count] = new wall().cons_cube_hollow_X_entrence_big_structure(0, -300);
            count++;
            map_constractor[count] = new wall().cons_plus_big_structure(500, 500);
            count++;
            map_constractor[count] = new wall().cons_cube_hollow_X_entrence_big_structure(550, 550);
            count++;
            map_constractor[count] = new wall().cons_five_cubes_X_big_structure(-300, 100);
            count++;
            map_constractor[count] = new wall().cons_five_cubes_X_big_structure(-150, -300);
            map_constractor[count] = new wall().solo_set_image(map_constractor[count],"https://i.ytimg.com/vi/h-cmvEFE7-E/hqdefault.jpg?custom=true&w=168&h=94&stc=true&jpg444=true&jpgq=90&sp=67&sigh=d3bmrUp0-Ea3CjdP0RDTAEbXfbU", 2);
            count++;
            map_constractor[count] = new wall().cons_smily_face_big_structure(-500, -500);
            count++;
            map_constractor[count] = new wall().convert_trap_to_wall(new trap().cons_big_cube(300, 0));
        }
        public map1(int map)
        {
            amount_map[0] = 10;
            map_constractor = new wall[amount_map[map]][];
            map1_setup();
        }
    }
}
