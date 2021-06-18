using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    class Classrpg
    {
        static void Main() 
        {
            Game game = new Game();

            while (true)
            {
                game.Process();
            }
        }
        
    }
}
