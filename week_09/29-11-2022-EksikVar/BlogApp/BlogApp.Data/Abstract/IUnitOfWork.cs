﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable 
    {
        IArticleRepository Articles { get; }//burada sadece get olucak. get veriyi çekmek.
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }  
        IUserRepository Users { get; }
        Task<int> SaveAsync();
    }
}
