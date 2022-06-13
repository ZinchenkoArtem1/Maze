using Maze.Entity;

namespace Maze.Service
{
    public interface IDoorService
    {
        void Create(Door door);
        Door Read(string id);
        List<Door> GetAll();
        void Update(Door door);
        void Delete(Door door);
    }
}
