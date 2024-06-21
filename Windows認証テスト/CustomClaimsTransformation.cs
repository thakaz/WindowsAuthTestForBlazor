using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Security.Claims;
using Windows認証テスト.DB;

namespace Windows認証テスト
{
    public class CustomClaimsTransformation : IClaimsTransformation
    {
        private readonly IDbContextFactory<TestDBContext> _dbFactory;

        public CustomClaimsTransformation(IDbContextFactory<TestDBContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var identity = (ClaimsIdentity)principal.Identity;

            var newIdentity = new ClaimsIdentity(identity.Claims, identity.AuthenticationType);

            //DBから取得したロール情報を追加
            using (var db = _dbFactory.CreateDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == identity.Name);

                if (user != null)
                {
                    //とりあえず1ならAdmin、それ以外はUserとする
                   // identity.AddClaim(new Claim(ClaimTypes.Role, user.Role == 1 ? "Admin" : "User"));
                    newIdentity.AddClaim(new Claim(ClaimTypes.Role, user.Role == 1 ? "Admin" : "User"));
                }
            }

            var newPrincipal = new ClaimsPrincipal(newIdentity);
            principal.AddIdentity(newIdentity);

            return Task.FromResult(principal);
        }
    }
}
