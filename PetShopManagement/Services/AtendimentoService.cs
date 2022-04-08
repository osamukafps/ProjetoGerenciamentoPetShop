using PetShopManagement.Data;
using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Services
{
    public class AtendimentoService
    {
        private readonly PetShopManagementContext _context;

        public AtendimentoService(PetShopManagementContext context)
        {
            _context = context;
        }

        public List<Atendimentos> ListarTodos()
        {
            return _context.Atendimentos.ToList();
        }

        public void NovoAtendimento(Atendimentos atendimeto)
        {

        }

    }
}
