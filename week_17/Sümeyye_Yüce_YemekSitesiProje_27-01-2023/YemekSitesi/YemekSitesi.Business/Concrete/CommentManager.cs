using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Business.Concrete
{
    public class CommentManager : ICommentService 
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Comment comment)
        {
            await _unitOfWork.Comments.CreateAsync(comment);
            await _unitOfWork.SaveAsync();
           
        }

        public void Delete(Comment comment)
        {
            _unitOfWork.Comments.Delete(comment);
            _unitOfWork.Save();
        }

        public async Task<List<Comment>> GetByFoodId(int foodId)
        {
            return await _unitOfWork.Comments.GetByFoodId(foodId);
          
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            return await _unitOfWork.Comments.GetByIdAsync(id);
           
        }

        public void Update(Comment comment)
        {
            _unitOfWork.Comments.Update(comment);
            _unitOfWork.Save();
        }
    }
}
