using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class DoorModel
    {
        public string Id { get; set; }
        public string Color { get; set; }
        public CellModel CellModel { get; set; }
        public bool IsOpen { get; set; }

        public override string ToString()
        {
            return "Door {" + CellModel.X + ", " + CellModel.Y + "}";
        }
    }
}
