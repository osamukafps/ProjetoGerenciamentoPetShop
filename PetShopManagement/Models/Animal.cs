using PetShopManagement.Models.Enums;
using System;
using System.Collections.Generic;
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
