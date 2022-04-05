using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models.Enums
{
    public enum ETipoEspecieAnimal
    {
        [Description("Cachorro")]
        Cachorro = 1,

        [Description("Gato")]
        Gato = 2,

        [Description("Hamster")]
        Hamster = 3,

        [Description("Porquinho da Índia")]
        PorquinhoDaIndia = 4,

        [Description("Calopsita")]
        Calopsita = 5

    }
}
