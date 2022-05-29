using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class Level : AbstractModel
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Complexity { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Decoration> Decorations { get; set; } = new List<Decoration>();
        public List<ArtifactCell> ArtifactCells { get; set; } = new List<ArtifactCell>();
        public int Points { get; set; }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
