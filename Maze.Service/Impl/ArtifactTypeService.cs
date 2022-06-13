using Maze.Entity;
using Maze.Repository;
using Maze.Repository.Impl;

namespace Maze.Service.Impl
{
    public class ArtifactTypeService : IArtifactTypeService
    {
        private readonly IArtifactTypeRepository artifactTypeRepository;

        public ArtifactTypeService()
        {
            this.artifactTypeRepository = new ArtifactTypeRepository();
        }

        public void Create(ArtifactType artifactType)
        {
            artifactTypeRepository.Create(artifactType);
        }

        public void Delete(ArtifactType artifactType)
        {
            artifactTypeRepository.Delete(artifactType);
        }

        public List<ArtifactType> GetAll()
        {
            return artifactTypeRepository.GetAll().ToList();
        }

        public ArtifactType Read(string id)
        {
            return artifactTypeRepository.Read(id);
        }

        public void Update(ArtifactType artifactType)
        {
            artifactTypeRepository.Update(artifactType);
        }
    }
}
