using Maze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Repository
{
    public class LevelRepository : GenericRepository<Level>
    {
        static LevelRepository()
        {
            //initial data for preview
            inMemoryDb.Add(new Level {
                Name = "Maze1",
                Color = "Black",
                Complexity = "Light",
                Height = 100,
                Weight = 100,
                Points = 100
            });
            inMemoryDb.Add(new Level
            {
                Name = "Maze2",
                Color = "White",
                Complexity = "Hard",
                Height = 150,
                Weight = 150,
                Points = 300
            });
            inMemoryDb.Add(new Level
            {
                Name = "Maze3",
                Color = "Red",
                Complexity = "Middle",
                Height = 125,
                Weight = 125,
                Points = 200
            });
        }
    }
}
