using Maze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : AbstractModel
    {
        protected static readonly List<TEntity> inMemoryDb  = new List<TEntity>();

        public virtual void Create(TEntity entity)
        {
            inMemoryDb.Add(entity);
        }

        public virtual TEntity Read(string id)
        {
            foreach(TEntity entity in inMemoryDb)
            {
                if(entity.Id.Equals(id)) return entity;
            }

            throw new ArgumentException("Entity with id: " + id + " not found");
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return inMemoryDb;
        }

        public virtual void Update(TEntity entity)
        {
            TEntity find = Read(entity.Id);
            find = entity;
        }

        public virtual void Delete(TEntity entity)
        {
            inMemoryDb.Remove(entity);
        }
    }
}
