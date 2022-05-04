using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetShopManagement.Data;
using PetShopManagement.Models;
using PetShopManagement.Models.ViewModels;
using PetShopManagement.Services;

namespace PetShopManagement.Controllers
{
    public class AtendimentosController : Controller
    {       
        private readonly AtendimentoService _atendimentoService;
        private readonly FuncionarioServices _funcionarioServices;
        private readonly ProdutoService _produtoService;
        private readonly ServicoServices _servicoService;
        private readonly AnimalService _animalService;

        public AtendimentosController(AtendimentoService atendimentoContext, FuncionarioServices funcionarioServices, ProdutoService produtoService, 
                                        ServicoServices servicoServices, AnimalService animalService)
        {
            _atendimentoService = atendimentoContext;
            _funcionarioServices = funcionarioServices;
            _produtoService = produtoService;
            _servicoService = servicoServices;
            _animalService = animalService;        
        }

        
        public IActionResult Index()
        {
            var atendimentos = new AtendimentoFormViewModelSaida();
            
            return View(_atendimentoService.ListarTodos());
        }

        //// GET: Atendimentos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var atendimentos = await _context.Atendimentos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (atendimentos == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(atendimentos);
        //}

        // GET: Atendimentos/Create
        public IActionResult Create()
        {               
            var produtos = _produtoService.ListarTodos();
            var funcionarios = _funcionarioServices.PesquisarTodos();
            var servicos = _servicoService.ListarTodos();
            var animais = _animalService.ListarTodos();
            var viewModel = new AtendimentoFormViewModel
            {
                DataAtendimento = DateTime.Now,
                Funcionarios = funcionarios,
                Produtos = produtos,
                Servicos = servicos,
                Animal = animais
            };
            return View(viewModel);
        }

        // POST: Atendimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Atendimentos atendimentos, int idFuncionario, int idAnimal, List<int> idServico, List<int> idProduto)
        {
            if(atendimentos.DataAtendimento < DateTime.Now)
            {
                throw new Exception();
            }
            if (ModelState.IsValid)
            {
                _atendimentoService.NovoAtendimento(atendimentos, idFuncionario, idAnimal, idServico, idProduto);               
                return RedirectToAction(nameof(Index));
            }
            return View(atendimentos);
        }

        // GET: Atendimentos/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var atendimentos = await _context.Atendimentos.FindAsync(id);
        //    if (atendimentos == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(atendimentos);
        //}

        //// POST: Atendimentos/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,DataAtendimento,ValorTotal")] Atendimentos atendimentos)
        //{
        //    if (id != atendimentos.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(atendimentos);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AtendimentosExists(atendimentos.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(atendimentos);
        //}

        //// GET: Atendimentos/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var atendimentos = await _context.Atendimentos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (atendimentos == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(atendimentos);
        //}

        //// POST: Atendimentos/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var atendimentos = await _context.Atendimentos.FindAsync(id);
        //    _context.Atendimentos.Remove(atendimentos);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AtendimentosExists(int id)
        //{
        //    return _context.Atendimentos.Any(e => e.Id == id);
        //}
    }
}
