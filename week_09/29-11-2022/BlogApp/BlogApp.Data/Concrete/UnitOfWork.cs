﻿using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete
{
    //_articleRepository ?? (yoksa demek)
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogAppContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;
        public UnitOfWork(BlogAppContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);  

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);  

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
          return await _context.SaveChangesAsync();
        }
    }
}