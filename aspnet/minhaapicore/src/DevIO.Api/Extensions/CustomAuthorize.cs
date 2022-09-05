using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DevIO.Api.Extensions
{
    public class CustomAuthorization
    {
        public static bool ValidarClaimUsuario(HttpContext httpContext, string claimName, string claimValue)
        {
            return httpContext.User.Identity.IsAuthenticated && httpContext.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }
    }

    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(RequisitoClaimFilter))
        {
            Arguments = new object[] { new Claim(claimName, claimValue) };
        }
    }

    public class RequisitoClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        public RequisitoClaimFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext authorizationFilterContext)
        {
            if (!authorizationFilterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                authorizationFilterContext.Result = new StatusCodeResult(401);
                return;
            }

            if(!CustomAuthorization.ValidarClaimUsuario(authorizationFilterContext.HttpContext, _claim.Type, _claim.Value))
            {
                authorizationFilterContext.Result = new StatusCodeResult(403);
            }
        }
    }

}
