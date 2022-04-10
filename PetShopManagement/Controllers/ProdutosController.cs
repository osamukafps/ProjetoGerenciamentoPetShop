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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Produtos produto)
        {
            _produtoService.AdicionarProduto(produto);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int? id, Produtos produto)
        {
            produto = _produtoService.EncontrarProdutoPorId(id);
            return View(produto);
        }
        [HttpPost]
        public IActionResult Edit(int id, Produtos produto)
        {
            _produtoService.EditarProduto(id, produto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id, Produtos produto)
        {
            produto =_produtoService.EncontrarProdutoPorId(id);
            return View(produto);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _produtoService.ExcluirProduto(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
