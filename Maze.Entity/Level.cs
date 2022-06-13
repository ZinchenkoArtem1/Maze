using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Entity
{
    public class Level : BaseEntity<string>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Complexity { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Door> Doors {get; set; }
        public List<Wall> Walls { get; set; }
        public List<Artifact> Artifacts { get; set; }
        public int Points { get; set; }

        public Level()
        {
            this.Id = Guid.NewGuid().ToString();
            Doors = new List<Door>();
            Artifacts = new List<Artifact>();
            Walls = new List<Wall>();

        }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
