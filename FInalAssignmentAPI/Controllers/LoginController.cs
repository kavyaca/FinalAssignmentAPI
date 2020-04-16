﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace SecureAPI
{
    public class LoginController : Controller
    {

        [HttpPost]
        [Route("api/Login")]
        public IActionResult Get(string username, string password)
        {
            if (username == password)
            {
                return new ObjectResult(GenerateToken(username));
            }
            else if (username == "admin" && password == "password")
            {
                return new ObjectResult(GenerateToken(username));
            }
            else
                return BadRequest();
        }

        // Generate a Token with expiration and Claim meta-data.
        // And sign the token with the SIGNING_KEY
        private string GenerateToken(string username)
        {


            var claims = new[] {
                   new Claim(JwtRegisteredClaimNames.GivenName, username),
                   new Claim("apitoken", "login"),

                               };

            var secretBytes = Encoding.UTF8.GetBytes(JWTKeys.Secret);

            var key = new SymmetricSecurityKey(secretBytes);

            var algorithm = SecurityAlgorithms.HmacSha256;

            var signingCredentials = new SigningCredentials(key, algorithm);

            var token = new JwtSecurityToken(
             JWTKeys.Issuer,
             JWTKeys.Audiance,
             claims,
             notBefore: DateTime.Now,
             expires: DateTime.Now.AddMinutes(20),
             signingCredentials
            );

            var tokenJson = new JwtSecurityTokenHandler().WriteToken(token);



            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}