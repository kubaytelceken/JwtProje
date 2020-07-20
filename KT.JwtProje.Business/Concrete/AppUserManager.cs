using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.DataAccess.Interfaces;
using KT.JwtProje.Entities.Concrete;
using KT.JwtProje.Entities.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KT.JwtProje.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>,IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IGenericDal<AppUser> genericDal, IAppUserDal appUserDal) :base(genericDal)
        {
            _appUserDal = appUserDal;
        }

        public async Task<bool> CheckPassword(AppUserLoginDto appUserLoginDto)
        {
           var appUser =  await _appUserDal.GetByFilter(I => I.UserName == appUserLoginDto.UserName);
            if(appUser.Password == appUserLoginDto.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<AppUser> FindByUserName(string userName)
        {
            return await _appUserDal.GetByFilter(I => I.UserName == userName); 
        }
    }
}
