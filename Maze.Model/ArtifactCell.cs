using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class ArtifactCell : AbstractModel
    {
        public Artifact Artifact { get; set; }  
        public Cell Cell { get; set; }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Name: " + Artifact.Name + "{" + Cell.X + ", " + Cell.Y + "}";
        }
    }
}
