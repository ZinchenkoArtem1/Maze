using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class ArtifactModel
    {
        public string Id { get; set; }
        public ArtifactTypeModel ArtifactType { get; set; }
        public CellModel CellModel { get; set; }

        public override string ToString()
        {
            return "Type: " + ArtifactType + " {" + CellModel.X + ", " + CellModel.Y + "}";
        }
    }
}
