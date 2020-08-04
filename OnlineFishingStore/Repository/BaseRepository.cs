using OnlineFishingStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineFishingStore.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ApplicationContext context;
        internal DbSet<TEntity> dbSet;

    }
}
