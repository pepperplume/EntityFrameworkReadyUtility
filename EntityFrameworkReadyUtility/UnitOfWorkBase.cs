using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkReadyUtility
{
    public class UnitOfWork<TDbContext> : IUnitOfWorkBase where TDbContext : DbContext
    {
        protected TDbContext _Context { get; private set; }

        public UnitOfWork(TDbContext context)
        {
            _Context = context;
        }

        public int Complete()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
