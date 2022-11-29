using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Shared.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Abstract
{
    public interface IArticleService
    {
        //Get,GetAll,Add,Delete,Update,HardDelete,GetAllByNoneDeleted,GetAllByDeletedActive,GetAllByCategory(categoryId)
        Task<IDataResult<ArticleDto>> Get(int articleId);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleted();//silinmemiş kayıtlar
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive();

        Task<IResult> Add(ArticleAddDto articleAddDto,string createdByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto,string modifiedByName);

        Task<IResult> Delete(int articleId, string modifiedByName);
        Task<IResult> HardDelete(int articleId);

    }
}
