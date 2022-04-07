using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    public class Servicos
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public double Valor { get; set; }
        #endregion

        #region Construtores
        public Servicos()
        {

        }

        public Servicos(int id, string nome, double valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
        #endregion
    }
}
