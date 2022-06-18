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
        void Create(Wall wall, string levelId);
        List<Wall> GetAllByLevelId(string levelId);
        void Update(Wall wall, string levelId);
        void Delete(Wall wall, string levelId);
    }
}
