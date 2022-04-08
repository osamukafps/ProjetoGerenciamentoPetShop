using Microsoft.EntityFrameworkCore;
using PetShopManagement.Data;
using PetShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Services
{
    public class FuncionarioServices
    {
        private readonly PetShopManagementContext _context;

        public FuncionarioServices(PetShopManagementContext context)
        {
            _context = context;
        }

        public List<Funcionario> PesquisarTodos()
        {
            return _context.Funcionario.ToList();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if(funcionario.Nome == null || funcionario.Email == null || funcionario.DataNascimento == null)
            {
                throw new ArgumentNullException();
            }
            _context.Funcionario.Add(funcionario);
            _context.SaveChanges();
        }

        public Funcionario EncontrarFuncionarioPorId(int? id)
        {
            var funcionario = _context.Funcionario.FirstOrDefault(x => x.Id == id);
            return funcionario;
        }

        public void RemoverFuncionario(int id)
        {
            var funcionario = _context.Funcionario.Find(id);
            _context.Funcionario.Remove(funcionario);
            _context.SaveChanges();
        }

        public void EditarFuncionario(int id, Funcionario funcionario)
        {
            
            if (funcionario.Nome == null || funcionario.Email == null || funcionario.DataNascimento == null)
            {
                throw new ArgumentNullException();
            }

            try
            {
                _context.Update(funcionario);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                throw;
            }            
        }
    }
}
