using Maze.Entity;

namespace Maze.Repository.Impl
{
    public class LevelRepository : GenericRepository<Level, string>, ILevelRepository
    {
        static LevelRepository()
        {
            //initial data for preview
            Level level1 = new Level
            {
                Name = "Maze1",
                Color = "Black",
                Complexity = "Light",
                Height = 100,
                Weight = 100,
                Points = 100
            };
            Level level2 = new Level
            {
                Name = "Maze2",
                Color = "White",
                Complexity = "Hard",
                Height = 150,
                Weight = 150,
                Points = 300
            };
            Level level3 = new Level
            {
                Name = "Maze3",
                Color = "Red",
                Complexity = "Middle",
                Height = 125,
                Weight = 125,
                Points = 200
            };
            inMemoryDb.Add(level1.Id, level1);
            inMemoryDb.Add(level2.Id, level2);
            inMemoryDb.Add(level3.Id, level3);
        }
    }
}
