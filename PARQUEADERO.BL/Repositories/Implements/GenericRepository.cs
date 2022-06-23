using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using PARQUEADERO.BL.Data;

namespace PARQUEADERO.BL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ParqueaderoContext parqueaderoContext;

        public GenericRepository(ParqueaderoContext parqueaderoContext)
        {
            this.parqueaderoContext = parqueaderoContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            parqueaderoContext.Set<TEntity>().Remove(entity);
            await parqueaderoContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await parqueaderoContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await parqueaderoContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            parqueaderoContext.Set<TEntity>().Add(entity);
            await parqueaderoContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            //parqueaderoContext.Entry(entity).State = EntityState.Modified;
            parqueaderoContext.Set<TEntity>().AddOrUpdate(entity);
            await parqueaderoContext.SaveChangesAsync();
            return entity;
        }
    }
}
