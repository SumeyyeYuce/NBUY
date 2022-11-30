using AutoMapper;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            //1.İşlem burası->articleManager->3.işlem burası->articleManager
            //.ForMember(dest => dest.CreatedDate, option => option.MapFrom(x => DateTime.Now));(burdaki 3. işlem burası)
            //articel için kullanıldıgım articleaddDto ve updatedto için bir map yaratıcaz

            CreateMap<ArticleAddDto, Article>()//dto ları article a dönüştürücek
                .ForMember(destination => destination.CreatedDate, option => option.MapFrom(x => DateTime.Now));

            CreateMap<ArticleUpdateDto, Article>()
                .ForMember(destination => destination.ModifiedDate, option => option.MapFrom(x => DateTime.Now));

        }
    }
}
