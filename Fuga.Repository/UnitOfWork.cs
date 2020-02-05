using Fuga.Repository.Context;
using Fuga.Repository.Infrasturecture;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuga.Repository
{
    public class UnitOfWork : IUnitOfWork//, IDisposable
    {
        #region Private Fields

        //private readonly FugaDbcontext _context = new FugaDbcontext();
        private readonly FugaContext _context = new FugaContext();
        private bool _disposed = true;
        private Hashtable _repositories;

        #endregion             

        #region Constuctor

        public UnitOfWork()
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }
        }

        #endregion Constuctor/Dispose

        public IStudentRepository<TEntity> Student<TEntity>() where TEntity : class
        {            
            return CreateRepositoryInstance<StudentRepository<TEntity>, IStudentRepository<TEntity>>();
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {            
            return CreateRepositoryInstance<Repository<TEntity>, IRepository<TEntity>>();            
        }

        //public void SaveChanges()
        //{
        //    _context.SaveChanges();
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        }

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!_disposed && disposing)
        //    {
        //        _context.Dispose();
        //    }
        //    _disposed = true;
        //}

        private U CreateRepositoryInstance<T, U>()
        {
            var model = typeof(T).GenericTypeArguments.FirstOrDefault();
            if (_repositories.ContainsKey(model.Name))
            {
                return (U)_repositories[model.Name];
            }
            var repositoryType = typeof(T).GetGenericTypeDefinition();
            _repositories.Add(model.Name, Activator.CreateInstance(repositoryType.MakeGenericType(model), _context));
            return (U)_repositories[model.Name];
        }


    }
}
