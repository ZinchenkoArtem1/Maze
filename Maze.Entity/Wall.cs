using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Entity
{
    public class Wall : BaseEntity<string>
    {
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsDanger { get; set; }
        public Level Level { get; set; }

        public Wall()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Wall {" + X + ", " + Y + "}";
        }
    }
}
