using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class ArtifactTypeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int AdditionalPoints { get; set; }

        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
