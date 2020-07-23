using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.Business.StringInfos;
using KT.JwtProje.Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KT.JwtProje.Business.Concrete
{
    public class JwtManager : IJwtService
    {
        public string GenerateJwt(AppUser appUser,List<AppRole> appRoles)
        {
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtInfo.SecurityKey));
            SigningCredentials signingCredentials = new SigningCredentials(symmetricSecurityKey,SecurityAlgorithms.HmacSha256);
            //kullanıcı ve o kullanıcının rolü lazım
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: JwtInfo.Issuer, audience: JwtInfo.Audience, notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(JwtInfo.TokenExpiration),signingCredentials: signingCredentials,claims:GetClaims(appUser,appRoles));
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(jwtSecurityToken);  
        }
        private List<Claim> GetClaims(AppUser appUser, List<AppRole> appRoles)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, appUser.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.Id.ToString()));
            if (appRoles?.Count > 0)
            {
                foreach (var role in appRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                }

            }
            return claims; 
        }
    }
}
