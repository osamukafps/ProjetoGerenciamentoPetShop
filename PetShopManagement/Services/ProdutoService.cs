using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        public Produtos EncontrarProdutoPorId(int? id)
        {
            var produto = _context.Produtos.FirstOrDefault(x => x.Id == id);
            return produto;
        }
        public void AdicionarProduto(Produtos produto)
        {
            _context.Produtos.Add(produto);           
            _context.SaveChanges();
        }

        public void EditarProduto(int id, Produtos produto)
        {
            if (produto.Nome == null || produto.Valor == null || produto.TipoProduto == null)
                throw new ArgumentNullException();

            try
            {
                _context.Produtos.Update(produto);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void ExcluirProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }


    }
}
