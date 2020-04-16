using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FInalAssignmentAPI
{
    public static class JWTKeys
    {
        public const string Audiance = "https://localhost:5001/";
        public const string Issuer = Audiance;
        public const string Secret = "this_is_my_api_assignment_of_corona_users_in_canada";
    }
}
