using Maze.Model;
using Maze.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Service.Impl
{
    public class LevelService : ILevelService
    {
        private readonly LevelRepository levelRepository;

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
            levelRepository.Delete(level);
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
    }
}
