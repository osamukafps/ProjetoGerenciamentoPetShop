using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShopManagement.Data;
using PetShopManagement.Models;

namespace PetShopManagement.Services
{
    public class ProdutoService
    {
        private readonly PetShopManagementContext _context;

        public ProdutoService(PetShopManagementContext context)
        {
            _context = context;
        }

        public List<Produtos> ListarTodos()
        {
            return _context.Produtos.ToList();
        }

        public void AdicionarProduto(Produtos produto)
        {
            _context.Produtos.Add(produto);           
            _context.SaveChanges();
        }
    }
}
