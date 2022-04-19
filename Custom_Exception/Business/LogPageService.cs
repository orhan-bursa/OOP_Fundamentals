using Custom_Exception.Model.Entities.Concrete;
using System.Windows.Forms;
using Custom_Exception.Repositories.Concrete;

namespace Custom_Exception.Business
{
    class LogPageService : ILogPageService
    {
        AppUserRepository appRepo = new AppUserRepository();

        public void CreateUser(string firstName, string lastName, string userName, int age)
        {
            AppUser appUser = new AppUser()
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                Age = age,
                Id = Utilities.FakeDb.AppUsers.Count + 1
            };
            appRepo.Create(appUser);            
        }
    }
}
