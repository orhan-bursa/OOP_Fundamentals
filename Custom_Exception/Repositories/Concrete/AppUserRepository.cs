using Custom_Exception.Model.Entities.Concrete;
using Custom_Exception.Repositories.Abstract;
using Custom_Exception.Utilities;

namespace Custom_Exception.Repositories.Concrete
{
    public class AppUserRepository : IAppUserRepository<AppUser>
    {
        public void Create(AppUser entity)
        {
            FakeDb.AppUsers.Add(entity);
        }
    }
}
