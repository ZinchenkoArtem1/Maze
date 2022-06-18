using Maze.Entity;

namespace Maze.Service
{
    public interface IArtifactService
    {
        void Create(Artifact artifact, string levelId);
        List<Artifact> GetAllByLevelId(string levelId);
        void Update(Artifact artifact, string levelId);
        void Delete(Artifact artifact, string levelId);
    }
}
