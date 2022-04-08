using PetShopManagement.Data;
using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Services
{
    public class ServicoServices
    {
        private readonly PetShopManagementContext _context;

        public ServicoServices(PetShopManagementContext contexto)
        {
            _context = contexto;
        }

        public List<Servicos> ListarTodos()
        {
            return _context.Servicos.OrderBy(x => x.Nome).ToList();
        }

    }
}
