using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Entity
{
    public class Door : BaseEntity<string>
    {
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsOpen { get; set; }
        public Level Level { get; set; }

        public Door()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Door {" + X + ", " + Y + "}";
        }
    }
}
