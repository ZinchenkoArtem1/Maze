using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public abstract class Decoration : AbstractModel
    {
        public string Color { get; set; }
        public Cell Cell { get; set; }  
    }
}
