using Fuga.Repository.Context;
using Fuga.Repository.Infrasturecture;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuga.Repository
{
    public class StudentRepository<TEntity> : Repository<TEntity>, IStudentRepository<TEntity> where TEntity : class
    {
        //private readonly FugaDbcontext _context;
        private readonly FugaContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public StudentRepository(FugaContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetStudentAll()
        {
            return _dbSet.AsQueryable().AsNoTracking();
        }
    }
}
