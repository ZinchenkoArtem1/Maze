using Maze.Entity;

namespace Maze.Repository.Impl
{
    public class ArtifactTypeRepository : GenericRepository<ArtifactType, string>, IArtifactTypeRepository
    {
        static ArtifactTypeRepository()
        {
            //initial data for preview
            ArtifactType artifactType1 = new ArtifactType
            {
                Name = "Key",
                AdditionalPoints = 10
            };
            ArtifactType artifactType2 = new ArtifactType
            {
                Name = "Apple",
                AdditionalPoints = 20
            };
            ArtifactType artifactType3 = new ArtifactType
            {
                Name = "Cherry",
                AdditionalPoints = 30
            };
            inMemoryDb.Add(artifactType1.Id, artifactType1);
            inMemoryDb.Add(artifactType2.Id, artifactType2);
            inMemoryDb.Add(artifactType3.Id, artifactType3);
        }
    }
}
