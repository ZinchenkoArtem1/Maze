using Maze.Entity;
using Maze.Repository;
using Maze.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Service.Impl
{
    public class WallService : IWallService
    {
        private readonly IWallRepository wallRepository;
        private readonly ILevelService levelService;  

        public WallService()
        {
            this.wallRepository = new WallRepository();
            this.levelService = new LevelService(); 
        }

        public void Create(Wall wall, string levelId)
        {
            Level level = levelService.Read(levelId);

            if (level.Weight < wall.X || level.Height < wall.Y)
            {
                throw new ArgumentException("Wall coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, wall.X, wall.Y);

            level.Walls.Add(wall);

            levelService.Update(level);
            wallRepository.Create(wall);
        }

        public void Delete(Wall wall, string levelId)
        {
            Level level = levelService.Read(levelId);

            level.Walls.RemoveAll(w => w.Id.Equals(wall.Id));

            levelService.Update(level);
            wallRepository.Delete(wall.Id);
        }

        public List<Wall> GetAllByLevelId(string levelId)
        {
            return levelService.Read(levelId).Walls;
        }

        public void Update(Wall wall, string levelId)
        {
            Level level = levelService.Read(levelId);

            if (level.Weight < wall.X || level.Height < wall.Y)
            {
                throw new ArgumentException("Wall coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, wall.X, wall.Y);

            level.Walls.RemoveAll(w => w.Id.Equals(wall.Id));
            level.Walls.Add(wall);

            levelService.Update(level);
            wallRepository.Update(wall);
        }
    }
}
