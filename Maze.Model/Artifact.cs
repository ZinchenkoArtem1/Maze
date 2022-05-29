using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public class Artifact : AbstractModel
    {
        public string Name { get; set; }
        public int AdditionalPoints { get; set; }

        //ToDo: write more informative 
        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
