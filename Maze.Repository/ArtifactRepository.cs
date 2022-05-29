using Maze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Repository
{
    public class ArtifactRepository : GenericRepository<Artifact>
    {
        static ArtifactRepository()
        {
            //initial data for preview
            inMemoryDb.Add(new Artifact
            {
                Name = "Key",
                AdditionalPoints = 10
            });
            inMemoryDb.Add(new Artifact
            {
                Name = "Apple",
                AdditionalPoints = 20
            });
            inMemoryDb.Add(new Artifact
            {
                Name = "Cherry",
                AdditionalPoints = 30
            });
        }
    }
}
