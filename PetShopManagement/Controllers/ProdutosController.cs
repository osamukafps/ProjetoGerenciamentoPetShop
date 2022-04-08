using Microsoft.AspNetCore.Mvc;
using PetShopManagement.Models;
using PetShopManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService contexto)
        {
            _produtoService = contexto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaProdutos = _produtoService.ListarTodos();            
            return View(listaProdutos);
        }

        public void Create(Produtos produto)
        {

        }
    }
}
