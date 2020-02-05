using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuga.Repository.Infrasturecture
{
    public interface IUnitOfWork //: IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;

        IStudentRepository<TEntity> Student<TEntity>() where TEntity : class;

        //void SaveChanges();
    }
}
