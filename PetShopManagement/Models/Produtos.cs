using PetShopManagement.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    public class Produtos
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public double Valor { get; set; }
        public ETipoProduto Tipo { get; set; }
        #endregion

        #region Construtores
        public Produtos()
        {
                
        }
        public Produtos(int id, string nome, double valor, ETipoProduto tipo)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Tipo = tipo;
        }
        #endregion
    }
}
