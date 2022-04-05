using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    public class Funcionario
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public ICollection<Atendimentos> Atendimentos { get; set; } = new List<Atendimentos>();
        #endregion

        #region Construtores
        public Funcionario()
        {

        }
        public Funcionario(int id, string nome, string email, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
        #endregion

        #region Métodos Públicos
        public void MarcarAtendimento(Atendimentos atendimento)
        {
            Atendimentos.Add(atendimento);
        }

        public void DesmarcarAtendimento(Atendimentos atendimentos)
        {
            Atendimentos.Remove(atendimentos);
        }
        
        public List<Atendimentos> TotalAtendimentos(DateTime inicio, DateTime fim)
        {
            return Atendimentos.Where(x => x.DataAtendimento >= inicio && x.DataAtendimento <= fim).ToList();
        }
        #endregion
    }
}
