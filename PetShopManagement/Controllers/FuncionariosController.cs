using Microsoft.AspNetCore.Mvc;
using PetShopManagement.Models;
using PetShopManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioServices _funcionarioService;

        public FuncionariosController(FuncionarioServices funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        public IActionResult Index()
        {
            var listaFuncionarios = _funcionarioService.PesquisarTodos();
            return View(listaFuncionarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Funcionario funcionario)
        {
            _funcionarioService.AdicionarFuncionario(funcionario);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var funcionario = _funcionarioService.EncontrarFuncionarioPorId(id.Value);

            if (funcionario == null)
                return NotFound();

            return View(funcionario);

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _funcionarioService.RemoverFuncionario(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id, Funcionario funcionario)
        {
            funcionario = _funcionarioService.EncontrarFuncionarioPorId(id.Value);           
            return View(funcionario);
        }

        [HttpPost]
        public IActionResult Edit(int id, Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _funcionarioService.EditarFuncionario(id, funcionario);               
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
