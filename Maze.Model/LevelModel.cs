using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class LevelModel 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Complexity { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<DoorModel> Doors {get; set; }
        public List<WallModel> Walls { get; set; }
        public List<ArtifactModel> Artifacts { get; set; }
        public int Points { get; set; }

        public LevelModel()
        {
            Doors = new List<DoorModel>();
            Artifacts = new List<ArtifactModel>();
            Walls = new List<WallModel>();
        }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
