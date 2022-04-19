using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception.Repositories.Abstract
{
    public interface IAppUserRepository<TEntity>
    {
        void Create(TEntity entity);
    }
}
