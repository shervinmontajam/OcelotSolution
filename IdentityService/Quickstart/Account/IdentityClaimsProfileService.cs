using IdentityServer4.Models;
using IdentityServer4.Services;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityService.Quickstart.Account
{
    public class IdentityClaimsProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var claims = new List<Claim>
            {
                new Claim("FullName", "Shervin Montajam")
            };

            context.IssuedClaims = claims;

            await Task.CompletedTask;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            //var sub = context.Subject.GetSubjectId();
            //var user = await _userRepository.FindAsync(Guid.Parse(context.Subject.GetSubjectId()));
            //context.IsActive = user != null;
            
            context.IsActive = true;

            await Task.CompletedTask;
        }
    }
}
