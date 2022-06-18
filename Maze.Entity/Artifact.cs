using Maze.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Entity
{
    public class Artifact : BaseEntity<string>
    {
        public ArtifactType ArtifactType { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Artifact()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return "Type: " + ArtifactType + " {" + X + ", " + Y + "}";
        }
    }
}
