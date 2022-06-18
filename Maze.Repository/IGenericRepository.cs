using Maze.Entity;

namespace Maze.Repository
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Read(TKey id);
        void Create(TEntity item);
        void Delete(TKey id);
        void Update(TEntity item);
    }
}
