using Maze.Entity;

namespace Maze.Service
{
    public interface ILevelService 
    {
        void Create(Level level);
        Level Read(string id);
        List<Level> GetAll();
        void Update(Level level);   
        void Delete(Level level);
        void IsLevelCellFree(Level level, int X, int Y);
    }
}
