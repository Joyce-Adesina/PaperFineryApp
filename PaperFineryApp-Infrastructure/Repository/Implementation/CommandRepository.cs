﻿using Microsoft.EntityFrameworkCore;
using PaperFineryApp_Infrastructure.Persistence;
using PaperFineryApp_Infrastructure.Repository.Abstraction;

namespace PaperFineryApp_Infrastructure.Repository.Implementation
{
    public class CommandRepository<T> : ICommandIRepository<T> where T : class
        {
            private readonly AppDbContext _appDbContext;
            public DbSet<T> _dbSet;

            public CommandRepository(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
                _dbSet = appDbContext.Set<T>();
            }

            public async Task CreateAsync(T entity) => await _dbSet.AddAsync(entity);

            public void DeleteAsync(T entity) => _dbSet.Remove(entity);

            public void RemoveRange(IEnumerable<T> entities) => _dbSet.RemoveRange(entities);

            public void Update(T entity) => _dbSet.Update(entity);

        }
}