using PetShopManagement.Data;
using PetShopManagement.Models;
using PetShopManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Services
{
    public class AtendimentoService
    {
        private readonly PetShopManagementContext _context;
        private readonly FuncionarioServices _funcionarioService;
        private readonly AnimalService _animaService;
        private readonly ServicoServices _servicoService;
        private readonly ProdutoService _produtoService;

        public AtendimentoService(PetShopManagementContext context, FuncionarioServices funcionarioServices, AnimalService animalService, ServicoServices servicoService, ProdutoService produtoService)
        {
            _context = context;
            _funcionarioService = funcionarioServices;
            _animaService = animalService;
            _servicoService = servicoService;
            _produtoService = produtoService;
        }

        public ICollection<Atendimentos> ListarTodos()
        {            
            return _context.Atendimentos.ToList();
        }

        public void NovoAtendimento(Atendimentos atendimento, int idFuncionario, int idAnimal, List<int> idServico, List<int> idProduto)
        {

            atendimento.Funcionario = _funcionarioService.EncontrarFuncionarioPorId(idFuncionario);
            atendimento.Animal = _animaService.EncontrarPorId(idAnimal);                        

            foreach(var item in idServico)
            {
                var servico = _servicoService.EncontrarPorId(item);
                atendimento.Servicos.Add(_servicoService.EncontrarPorId(item));
                atendimento.ValorTotal += servico.Valor;
            }

            foreach(var item in idProduto)
            {
                var produto = _produtoService.EncontrarProdutoPorId(item);
                atendimento.Produtos.Add(_produtoService.EncontrarProdutoPorId(item));
                atendimento.ValorTotal += produto.Valor;
            }

            _context.Atendimentos.Add(atendimento);
            _context.SaveChanges();
        }

        public double CalcularValorTotal(double valorServico, double valorProduto)
        {
            return valorProduto + valorServico;
        }
    }
}
