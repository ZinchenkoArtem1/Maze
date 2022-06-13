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
    public class ArtifactService : IArtifactService 
    {
        private readonly IArtifactRepository artifactRepository;
        private readonly ILevelService levelService;

        public ArtifactService()
        {
            this.artifactRepository = new ArtifactRepository();
            this.levelService = new LevelService();
        }

        public void Create(Artifact artifact)
        {
            Level level = artifact.Level;

            if (level.Weight < artifact.X || level.Height < artifact.Y)
            {
                throw new ArgumentException("Artifact coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, artifact.X, artifact.Y);

            level.Artifacts.Add(artifact);
            artifactRepository.Create(artifact);
        }

        public void Delete(Artifact artifact)
        {
            artifactRepository.Delete(artifact);
        }

        public List<Artifact> GetAll()
        {
            return artifactRepository.GetAll().ToList();
        }

        public Artifact Read(string id)
        {
            return artifactRepository.Read(id);
        }

        public void Update(Artifact artifact)
        {
            Level level = artifact.Level;

            if (level.Weight < artifact.X || level.Height < artifact.Y)
            {
                throw new ArgumentException("Artifact coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, artifact.X, artifact.Y);

            artifactRepository.Update(artifact);
        }
    }
}
