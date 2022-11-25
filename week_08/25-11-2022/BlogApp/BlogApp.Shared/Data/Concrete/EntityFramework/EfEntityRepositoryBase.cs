using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Concrete.EntityFramework
{
    //solid ilkelerine bak.
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class,
        IEntity,
        new()
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); }); 
        }
        public async Task UpdateAsync(TEntity entity)
        {
           await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }
        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            //burada conteximize erişip hangi entity ile çalışıcaksak o entityi qeryable tipini alıyoruz ki sonra
            //bunun arksında where include gibi yapıları duruma göre ekleyebilelim.
            IQueryable<TEntity> query = _context.Set<TEntity>(); 
            if (predicate!=null)//predicate null değilse
            {
                query = query.Where(predicate);//yukarıdan gelen query'nin içine predicate 'i ekle
            }
            if (includeProperties.Any())//dizinin içinde elaman varmı yok mu ou anlıyoruz.
            {
                foreach (var includeProperty in includeProperties)//yukarıdaki diziyi döngü oluşturarak sırasıyla yazdırdık
                {
                    query = query.Include(includeProperty);//query nin içine includepropertie den gelen değeri yazdır.
                }
            }
            return await query.ToListAsync();  //query'yi listeye çevirerek döndrdük
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query=_context.Set<TEntity>();
            query=query.Where(predicate);
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            //GERİYE DÖNDÜRÜCEGİ ŞEY ARTIK TEKİL BİŞEY
            return await query.FirstOrDefaultAsync(); //gelen sonuca bakar gelenlerin içinde ilk karşılatıgını getirir.birden fazla olabilir ama bi tanesi getiri.
            //return await query.SingleOrDefaultAsync(); bu ise gerçekten bi tane kayıt oldugunu biliyosak bunu kullanrız örnegin Id UNİK.


        }


    }
}
