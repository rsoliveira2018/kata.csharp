using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Extensions
{
    public class IdentityMensagensPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = "Ocorreu um erro desconhecido." }; }
        public override IdentityError DuplicateUserName(string userName) { return new IdentityError { Code = nameof(DuplicateUserName), Description = $"Login '{userName}' já está sendo utilizado." }; }
    }
}
