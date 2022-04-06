using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

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
    }
}
