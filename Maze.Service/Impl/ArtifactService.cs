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

        public void Create(Artifact artifact, string levelId)
        {
            Level level = levelService.Read(levelId);

            if (level.Weight < artifact.X || level.Height < artifact.Y)
            {
                throw new ArgumentException("Artifact coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, artifact.X, artifact.Y);

            level.Artifacts.Add(artifact);

            levelService.Update(level);
            artifactRepository.Create(artifact);
        }

        public void Delete(Artifact artifact, string levelId)
        {
            Level level = levelService.Read(levelId);
            level.Artifacts.RemoveAll(a => a.Id.Equals(artifact.Id));

            levelService.Update(level);
            artifactRepository.Delete(artifact.Id);
        }

        public List<Artifact> GetAllByLevelId(string levelId)
        {
            return levelService.Read(levelId).Artifacts;
        }

        public void Update(Artifact artifact, string levelId)
        {
            Level level = levelService.Read(levelId);

            if (level.Weight < artifact.X || level.Height < artifact.Y)
            {
                throw new ArgumentException("Artifact coordinates is more than level size");
            }
            levelService.IsLevelCellFree(level, artifact.X, artifact.Y);

            level.Artifacts.RemoveAll(a => a.Id.Equals(artifact.Id));
            level.Artifacts.Add(artifact);

            artifactRepository.Update(artifact);
            levelService.Update(level);
        }
    }
}
