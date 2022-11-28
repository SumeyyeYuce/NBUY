using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstract
{
    public interface IEntityRepository<T>
        where T:class,//t class olmalı ıentity olmalı.
        IEntity,
        new()//<T> Generic demek
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[]includeProperties);//Not-1,Not-2
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);//Not-3
        Task AddAsync(T entity);//burdaki entity değiken adı istediğimizi verebiliriz.
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T,bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
      
    }
}
/*
 * Not-1
 * ******
 * Örneğin Id'si 12 olan Article'ı getirmek istiyoruz
 * var article=repository.GetAsync(x=>x.Id==12);
 * User user=repositoryUser.GetAsync(x=>x.Name=="sümeyye")
 *
 *Not-2
 *******
 *Örneğin Id'si 12 olan Article'ı User ve Comment'leriyle birlikte getirmek istiyoruz
 *Article article=repositoryArticle.GetAsync(x=>x.Id==12, y=>y.User, y=>y.Comments, z=>z.Role)
 *
 *Not-3
 *******
 *Örneğn tüm Articel'ları listelemek istiyoruz.
 *var articles=repositoryArticel.GetAllAsync();
 *Örneğin Dotnet kategorisideki tüm articel lerı listelemek isyiyoruz.
 *var articles=repoistoryArticle.GetAllAsync(a=>a.Category.Name=="DotNet", c=>c.Category)
 *Örnegin Id'si 12 olan Articel ın yorumlarını getirmek isyitrız.
 *var comments=repositoryComment.GetAllAsync(c=>c.ArticleId==12)
 */