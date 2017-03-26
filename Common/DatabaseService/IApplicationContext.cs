using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DatabaseService
{
    public interface IApplicationContext
    {
        DbSet<User> User { get; set; }
    }
}
