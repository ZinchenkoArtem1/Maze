using Maze.Entity;
using Maze.Repository;
using Maze.Repository.Impl;

namespace Maze.Service.Impl
{
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository levelRepository;

        public LevelService()
        {
            levelRepository = new LevelRepository();
        }

        public void Create(Level level)
        {
            levelRepository.Create(level);
        }

        public void Delete(Level level)
        {
            levelRepository.Delete(level.Id);
        }

        public Level Read(string id)
        {
            return levelRepository.Read(id);
        }

        public List<Level> GetAll()
        {
            return levelRepository.GetAll().ToList();
        }

        public void Update(Level level)
        {
            levelRepository.Update(level);
        }

        public void IsLevelCellFree(Level level, int X, int Y)
        {
            level.Doors.ToList().ForEach(
                d =>
                {
                    if(d.X == X && d.Y == Y)
                    {
                        throw new Exception(String.Format("Cell [{0}, {1}] is already busy by door", d.X, d.Y));
                    }
                }    
            );

            level.Walls.ToList().ForEach(
                w =>
                {
                    if (w.X == X && w.Y == Y)
                    {
                        throw new Exception(String.Format("Cell [{0}, {1}] is already busy by wall", w.X, w.Y));
                    }
                }
            );

            level.Artifacts.ToList().ForEach(
                a =>
                {
                    if (a.X == X && a.Y == Y)
                    {
                        throw new Exception(String.Format("Cell [{0}, {1}] is already busy by artifact", a.X, a.Y));
                    }
                }
            );
        }
    }
}
