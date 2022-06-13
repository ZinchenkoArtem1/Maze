using Maze.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Service
{
    public interface IWallService
    {
        void Create(Wall wall);
        Wall Read(string id);
        List<Wall> GetAll();
        void Update(Wall wall);
        void Delete(Wall wall);
    }
}
