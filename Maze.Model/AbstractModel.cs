using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model
{
    public abstract class AbstractModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
