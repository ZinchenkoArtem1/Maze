using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Entity
{
    public class ArtifactType : BaseEntity<string>
    {
        public string Name { get; set; }
        public int AdditionalPoints { get; set; }

        public ArtifactType()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
