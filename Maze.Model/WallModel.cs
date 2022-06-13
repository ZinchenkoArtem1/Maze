using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class WallModel
    {
        public string Id { get; set; }
        public string Color { get; set; }
        public CellModel CellModel { get; set; }
        public bool IsDanger { get; set; }

        public override string ToString()
        {
            return "Wall {" + CellModel.X + ", " + CellModel.Y + "}";
        }
    }
}
