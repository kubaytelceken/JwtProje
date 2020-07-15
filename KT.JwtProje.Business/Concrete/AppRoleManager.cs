using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.DataAccess.Interfaces;
using KT.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Business.Concrete
{
    public class AppRoleManager : GenericManager<AppRole>,IAppRoleService
    {
        public AppRoleManager(IGenericDal<AppRole> genericDal) : base(genericDal)
        {

        }
    }
}
