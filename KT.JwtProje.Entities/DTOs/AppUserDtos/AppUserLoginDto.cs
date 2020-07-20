using KT.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Entities.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
