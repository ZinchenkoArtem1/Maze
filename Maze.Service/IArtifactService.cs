using Maze.Entity;

namespace Maze.Service
{
    public interface IArtifactService
    {
        void Create(Artifact artifact);
        Artifact Read(string id);
        List<Artifact> GetAll();
        void Update(Artifact artifact);
        void Delete(Artifact artifact);
    }
}
