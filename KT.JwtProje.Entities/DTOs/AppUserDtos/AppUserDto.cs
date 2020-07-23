using KT.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.JwtProje.Entities.DTOs.AppUserDtos
{
    public class AppUserDto : IDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
