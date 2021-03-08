using Microsoft.EntityFrameworkCore;
using Blazor_Server_Crud.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Server_Crud.Server.Data
{
    public class empDbContext:DbContext
    {
            public empDbContext(DbContextOptions<empDbContext> options)
              : base(options)
            {

            }
            public DbSet<empInfo> empTable { get; set; }

            public DbSet<itemDetail> itemDetailTable { get; set; }
        
    }
    
}
