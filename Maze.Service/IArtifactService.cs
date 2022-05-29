using Maze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
