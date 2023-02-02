using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;

namespace Application.Models
{
    public class ApplicationUserStore
            : UserStore<ApplicationUser, ApplicationRole, string,
                ApplicationUserLogin, ApplicationUserRole,
                ApplicationUserClaim>, IUserStore<ApplicationUser, string>,
            IDisposable
    {
        public ApplicationUserStore()
            : this(new IdentityDbContext())
        {
            base.DisposeContext = true;
        }

        public ApplicationUserStore(DbContext context)
            : base(context)
        {
        }
    }
}