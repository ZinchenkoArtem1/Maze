using Maze.Entity;

namespace Maze.Service
{
    public interface IArtifactTypeService
    {
        void Create(ArtifactType artifactType);
        ArtifactType Read(string id);
        List<ArtifactType> GetAll();
        void Update(ArtifactType artifactType);
        void Delete(ArtifactType artifactType);
    }
}
