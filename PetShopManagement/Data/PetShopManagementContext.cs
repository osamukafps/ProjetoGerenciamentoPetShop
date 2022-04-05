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
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Atendimentos> Atendimentos { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
