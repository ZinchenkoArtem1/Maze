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

        public void Create(Door door, string levelId)
        {
            Level level = levelService.Read(levelId);

            if (level.Weight < door.X || level.Height < door.Y)
            {
                throw new ArgumentException("Door coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, door.X, door.Y);

            level.Doors.Add(door);

            levelService.Update(level);
            doorRepository.Create(door);
        }

        public void Delete(Door door, string levelId)
        {
            Level level = levelService.Read(levelId);

            level.Doors.RemoveAll(d => d.Id.Equals(door.Id));

            levelService.Update(level);
            doorRepository.Delete(door.Id);
        }

        public List<Door> GetAllByLevelId(string levelId)
        {
            return levelService.Read(levelId).Doors;
        }

        public void Update(Door door, string levelId)
        {
            Level level = levelService.Read(levelId);

            if (level.Weight < door.X || level.Height < door.Y)
            {
                throw new ArgumentException("Door coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, door.X, door.Y);

            level.Doors.RemoveAll(d => d.Id.Equals(door.Id));
            level.Doors.Add(door);

            levelService.Update(level);
            doorRepository.Update(door);
        }
    }
}
