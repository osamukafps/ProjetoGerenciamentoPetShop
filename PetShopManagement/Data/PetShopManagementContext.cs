using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShopManagement.Models;

namespace PetShopManagement.Data
{
    public class PetShopManagementContext : DbContext
    {
        public PetShopManagementContext (DbContextOptions<PetShopManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Servicos> Servicos { get; set; }
    }
}
