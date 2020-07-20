using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.Entities.DTOs.AppUserDtos;
using KT.JwtProje.WebApi.CustomFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KT.JwtProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IAppUserService _appUserService;
        public AuthController(IJwtService jwtService, IAppUserService appUserService)
        {
            _jwtService = jwtService;
            _appUserService = appUserService;
        }
        [HttpGet("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignIn(AppUserLoginDto appUserLoginDto)
        {
            //?
            //_jwtService.GenerateJwt();
            var appUser = await _appUserService.FindByUserName(appUserLoginDto.UserName);
            if(appUser == null)
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı.");
            }
            else
            {
                if(await _appUserService.CheckPassword(appUserLoginDto))
                {
                    var token = _jwtService.GenerateJwt(appUser, null);
                    return Created("",token);
                }
                else
                {
                    return BadRequest("Kullanıcı adı veya şifre hatalı.");
                }
            }
           
        }
    }
}
