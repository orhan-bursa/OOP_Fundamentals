using Custom_Exception.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception.Utilities
{
    public static class FakeDb
    {
        public static List<AppUser> AppUsers = new List<AppUser>()
        {
            new AppUser{ Id =1,FirstName="Burak",LastName="Yılmaz",UserName="beast",Password="123", Age = 33 },
            new AppUser{ Id =2,FirstName="İpek",LastName="Yılmaz",UserName="keko",Password="123", Age = 38 },
            new AppUser{ Id =3,FirstName="Hakan",LastName="Yılmaz",UserName="savage",Password="123", Age = 36 }
        };
    }
}
