﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

//namespace Dealership.Data
//{
//    public class CustomAuthStateProvider : AuthenticationStateProvider
//    {
//        public override Task<AuthenticationState> GetAuthenticationStateAsync()
//        {
//            var identity = new ClaimsIdentity(new[] {
//                new Claim(ClaimTypes.Name =),
//                }, "apiauth_type");

//            var user = new ClaimsPrincipal(identity);

//            return Task.FromResult(new AuthenticationState(user));
//        }
//    }
//}
