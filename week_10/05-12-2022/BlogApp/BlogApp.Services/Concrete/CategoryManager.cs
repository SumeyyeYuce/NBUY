﻿using AutoMapper;
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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<CategoryDto>> Get(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);
            if (category!=null)//aranan kategori bulunduysa
            {
                //dataresultdan gelen categoryDto için bu işlemleri döndür
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,//category dışarıdann gelen kategoriye eşşit olsun
                    ResultStatus=ResultStatus.Success//resultStatus Success olsun.
                });
            }
            //geriye DataResult tipinde bir mesaj döndersin
            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null,c=>c.Articles);
            if (categories.Count>0)//kategori sayısı sıfırdan büyükse
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus=ResultStatus.Success
                });
            }
            //hata mesajı döndürsün
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç kategori bulunamadı", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c=>c.Articles);
            if (categories.Count>0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted && c.IsActive, c=>c.Articles);
            if (categories.Count>0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç kategori bulunamadı.", null);
        }

        //kategori ekleme işlemlerini burada Add ile yapıyoruz
        public async Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            var category = _mapper.Map<Category>(categoryAddDto);//map'leme işlemi
            category.CreatedByName = createdByName;//category.CreatedByName eşittir dışarıdan aldıgımız creatdName diyoruz
            category.ModifiedByName = createdByName;
           var addedCategory= await _unitOfWork.Categories.AddAsync(category);
               await _unitOfWork.SaveAsync();//save işlemini yapıyoruz

            //burada 3 parametre geri dönderiyoruz(resultStatus success ise,categorinin adı eklendi mesajı,birde yeni kategori ekledniğinde resultStatus işlemleri)
            return new DataResult<CategoryDto>(ResultStatus.Success, $"{categoryAddDto.Name} adlı kategori başarıyla eklenmiştir.",new CategoryDto
            {
                Category=addedCategory,
                ResultStatus=ResultStatus.Success,
                Message=$"{categoryAddDto.Name} adlı kategori başarıyla eklenmiştir."
            });
        }

        //kategori güncelleme işlemleri
        public async Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
         
                var category = _mapper.Map<Category>(categoryUpdateDto);
                category.ModifiedByName = modifiedByName;
                var updateCategory= await _unitOfWork.Categories.UpdateAsync(category);
                   await _unitOfWork.SaveAsync();
                return new DataResult<CategoryDto>(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarıyla güncellenmiştir.",new CategoryDto
                {
                    Category=updateCategory,
                    ResultStatus=ResultStatus.Success,
                    Message = $"{categoryUpdateDto.Name} adlı kategori başarıyla güncellenmiştir."

                });
         
        }

        public async Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {

                var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
                category.IsDeleted = true;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;

                await _unitOfWork.Categories.UpdateAsync(category);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{category.Name} başlıklı kategori başarıyla silinmiştir.");

            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.");
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result) 
            {
                var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} başlıklı kategori başarıyla veritabanından silinmiştir.");

            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.");
        }
    }
}
