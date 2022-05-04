using PetShopManagement.Data;
using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Services
{
    public class AnimalService
    {
        private readonly PetShopManagementContext _context;

        public AnimalService(PetShopManagementContext context)
        {
            _context = context;
        }

        public List<Animal> ListarTodos()
        {
            return _context.Animal.ToList();
        }

        public Animal EncontrarPorId(int id)
        {
            return _context.Animal.FirstOrDefault(x => x.Id == id);
        }
    }
}
