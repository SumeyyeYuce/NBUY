using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.Abstract;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public async Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            await _unitOfWork.Articles.AddAsync(new Article //contexte eklendi
            {
                Title= articleAddDto.Title, 
                Content= articleAddDto.Content, 
                Thumbnail= articleAddDto.Thumbnail, 
                Date=articleAddDto.Date,
                SeoAuthor= articleAddDto.SeoAuthor, 
                SeoDescription= articleAddDto.SeoDescription,   
                SeoTags= articleAddDto.SeoTags, 
                IsActive= articleAddDto.IsActive,   
                CategoryId= articleAddDto.CategoryId,   
                CreatedDate=DateTime.Now,
                CreatedByName= createdByName,
                ModifiedDate= DateTime.Now,
                ModifiedByName= createdByName,
                IsDeleted=false,
            }).ContinueWith(t=>_unitOfWork.SaveAsync());

            //await _unitOfWork.SaveAsync();//çagırdı
            return new Result(ResultStatus.Success, $"{articleAddDto.Title} başlıklı makale başarıyla eklenmiştir");

        }

        public Task<IResult> Delete(int articleId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var articles = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId, a => a.Category ,a=>a.User);
            if (articles!=null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                { 
                    Article=articles,
                    ResultStatus=ResultStatus.Success
                
                });
            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Böyle bir Makale bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(null, a=>a.Category, a => a.User);//bütün verileri article la beraber veritabanından çek(kategori tipinde liste döndrüor)
            if (articles.Count > 0)//buraya bir kategori gelmişse
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                   Articles= articles,
                   ResultStatus =ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç Makale bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleted()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(c => !c.IsDeleted, c => c.Category, a => a.User);
            if (articles.Count > 0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles= articles,
                    ResultStatus=ResultStatus.Success

                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı.", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(c => !c.IsDeleted && c.IsActive, c => c.Category , a => a.User);
            if (articles.Count > 0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                       Articles=articles,
                       ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);
        }

        public Task<IResult> HardDelete(int articleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
