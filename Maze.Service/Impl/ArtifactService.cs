using Maze.Model;
using Maze.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Service.Impl
{
    public class ArtifactService : IArtifactService
    {
        private readonly ArtifactRepository artifactRepository;

        public ArtifactService()
        {
            this.artifactRepository = new ArtifactRepository();
        }

        public void Create(Artifact artifact)
        {
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
            artifactRepository.Update(artifact);
        }
    }
}
