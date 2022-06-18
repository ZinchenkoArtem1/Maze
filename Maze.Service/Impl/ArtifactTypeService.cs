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

        public List<ArtifactType> GetAll()
        {
            return artifactTypeRepository.GetAll().ToList();
        }
    }
}
