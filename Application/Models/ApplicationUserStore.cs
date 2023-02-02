using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;

namespace Application.Models
{
    public partial class IdentityModels
    {
        // Most likely won't need to customize these either, but they were needed because we implemented
        // custom versions of all the other types:
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
}