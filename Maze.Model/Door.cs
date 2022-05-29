using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class Door : Decoration
    {
        public bool IsOpen { get; set; }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Door {" + Cell.X + ", " + Cell.Y + "}";
        }
    }
}
