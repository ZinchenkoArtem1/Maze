using Maze.Entity;

namespace Maze.Service
{
    public interface IDoorService
    {
        void Create(Door door, string levelId);
        List<Door> GetAllByLevelId(string levelId);
        void Update(Door door, string levelId);
        void Delete(Door door, string levelId);
    }
}
