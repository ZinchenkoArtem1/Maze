using Maze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Service
{
    public interface ILevelService 
    {
        void Create(Level level);
        Level Read(string id);
        List<Level> GetAll();
        void Update(Level level);   
        void Delete(Level level);
        
    }
}
