using KT.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Business.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> appRoles);
    }
}
