using Fuga.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuga.Repository.Context
{
    public class FugaDbcontext : DbContext, IDisposable
    {

       
        public FugaDbcontext() : base("name=FugaDbcontext")
        {
        }

        public virtual DbSet<Student> Student { get; set; }

    }
}
