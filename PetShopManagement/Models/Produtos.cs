using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    public class Produtos
    {
        #region Propriedades
        [Display(Name = "ID")]
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public double Valor { get; set; }
        
        [Display(Name = "Tipo do Produto")]
        public Tipo TipoProduto { get; set; }

        public enum Tipo
        {
            [Display(Name = "Alimentação")]
            Alimentacao = 1,

            [Display(Name = "Higiene & Saúde")]
            Higiene = 2,

            [Display(Name = "Vestuário")]
            Vestuario = 3,

            [Display(Name = "Lazer")]
            Lazer = 4,

            [Display(Name = "Habitação")]
            Habitacao = 5
        }
        #endregion

        #region Construtores
        public Produtos()
        {

        }
        public Produtos(int id, string nome, double valor, Tipo tipo)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            TipoProduto = tipo;
        }
        #endregion
    }
}
