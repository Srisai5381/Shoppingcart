using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModels
{
    public class SecDbContext : DbContext
    {
        public SecDbContext(DbContextOptions<SecDbContext> options)
            : base(options)
        {
        }
    }
}
