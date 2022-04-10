using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    public class Animal
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public ETipoEspecieAnimal Especie { get; set; }
        public string Raca { get; set; }

        public enum ETipoEspecieAnimal
        {
            [Display(Name = "Cachorro")]
            Cachorro = 1,

            [Display(Name = "Gato")]
            Gato = 2,

            [Display(Name = "Hamster")]
            Hamster = 3,

            [Display(Name = "Porquinho da Índia")]
            PorquinhoDaIndia = 4,

            [Display(Name = "Calopsita")]
            Calopsita = 5

        }
        #endregion

        #region Construtores
        public Animal()
        {

        }
        public Animal(int id, string nome, ETipoEspecieAnimal especie, string raca)
        {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
        }
        #endregion
    }
}
