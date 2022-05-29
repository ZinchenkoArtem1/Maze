using Maze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : AbstractModel
    {
        IEnumerable<TEntity> GetAll();
        TEntity Read(string id);
        void Create(TEntity item);
        void Delete(TEntity item);
        void Update(TEntity item);
    }
}
