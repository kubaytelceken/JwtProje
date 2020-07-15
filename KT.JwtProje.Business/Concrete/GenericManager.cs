using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.DataAccess.Interfaces;
using KT.JwtProje.Entities.Concrete;
using KT.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KT.JwtProje.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        private IGenericDal<AppUserRole> genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public GenericManager(IGenericDal<AppUserRole> genericDal)
        {
            this.genericDal = genericDal;
        }

        public async Task Add(TEntity entity)
        {
            await _genericDal.Add(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _genericDal.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _genericDal.GetById(id);
        }

        public async Task Remove(TEntity entity)
        {
            await _genericDal.Remove(entity);
        }

        public async Task Update(TEntity entity)
        {
            await _genericDal.Update(entity);
        }
    }
}
