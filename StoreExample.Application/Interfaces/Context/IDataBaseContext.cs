using Microsoft.EntityFrameworkCore;
using StoreExample.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoreExample.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {
       DbSet<User> Users { get; set; }
       DbSet<Role> Roles { get; set; }
       DbSet<UserInRole> UserInRoles { get; set; }


        int SaveChange(bool acceptAllChangesOnSuccess);
        int SaveChange();
        Task<int> SavechangeAcync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken() );
        Task<int> SavechangeAcync(CancellationToken cancellationToken = new CancellationToken());
    }
}
