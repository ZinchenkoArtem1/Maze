using Maze.Entity;
using Maze.Repository;
using Maze.Repository.Impl;

namespace Maze.Service.Impl
{
    public class DoorService : IDoorService
    {
        private readonly IDoorRepository doorRepository;
        private readonly ILevelService levelService;  

        public DoorService()
        {
            doorRepository = new DoorRepository();
            levelService = new LevelService();
        }

        public void Create(Door door)
        {
            Level level = door.Level;

            if (level.Weight < door.X || level.Height < door.Y)
            {
                throw new ArgumentException("Door coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, door.X, door.Y);

            level.Doors.Add(door);
            doorRepository.Create(door);
        }

        public void Delete(Door door)
        {
            doorRepository.Delete(door);
        }

        public Door Read(string id)
        {
            return doorRepository.Read(id);
        }

        public List<Door> GetAll()
        {
            return doorRepository.GetAll().ToList();
        }

        public void Update(Door door)
        {
            Level level = door.Level;

            if (level.Weight < door.X || level.Height < door.Y)
            {
                throw new ArgumentException("Door coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, door.X, door.Y);

            doorRepository.Update(door);
        }
    }
}
