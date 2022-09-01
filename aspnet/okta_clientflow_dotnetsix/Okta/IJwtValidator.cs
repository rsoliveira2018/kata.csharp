using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace okta_clientflow_dotnetsix.Okta
{
    public interface IJwtValidator
    {
        Task<JwtSecurityToken> ValidateToken(string token, CancellationToken ct = default(CancellationToken));
    }
}
