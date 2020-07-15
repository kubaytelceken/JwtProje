using KT.JwtProje.DataAccess.Interfaces;
using KT.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRoleRepository : EfGenericRepository<AppUserRole>,IAppUserRoleDal
    {

    }
}
