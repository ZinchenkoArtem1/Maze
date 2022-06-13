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

        public void Create(Wall wall)
        {
            Level level = wall.Level;

            if (level.Weight < wall.X || level.Height < wall.Y)
            {
                throw new ArgumentException("Wall coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, wall.X, wall.Y);

            level.Walls.Add(wall);
            wallRepository.Create(wall);
        }

        public void Delete(Wall wall)
        {
            wallRepository.Delete(wall);
        }

        public List<Wall> GetAll()
        {
            return wallRepository.GetAll().ToList();
        }

        public Wall Read(string id)
        {
            return wallRepository.Read(id);
        }

        public void Update(Wall wall)
        {
            Level level = wall.Level;

            if (level.Weight < wall.X || level.Height < wall.Y)
            {
                throw new ArgumentException("Wall coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, wall.X, wall.Y);

            wallRepository.Update(wall);
        }
    }
}
