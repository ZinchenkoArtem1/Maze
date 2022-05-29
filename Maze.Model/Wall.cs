using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class Wall : Decoration
    {
        public bool IsDanger { get; set; }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Wall {" + Cell.X + ", " + Cell.Y + "}";
        }
    }
}
