using PetShopManagement.Data;
using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Services
{
    public class FuncionarioServices
    {
        private readonly PetShopManagementContext _context;

        public FuncionarioServices(PetShopManagementContext context)
        {
            _context = context;
        }

        public List<Funcionario> PesquisarTodos()
        {
            return _context.Funcionario.ToList();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
            _context.SaveChanges();
        }
    }
}
