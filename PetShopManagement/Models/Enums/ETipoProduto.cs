using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models.Enums
{
    public enum ETipoProduto
    {
        [Description("Alimentação")]
        Alimentacao = 1,

        [Description("Higiene & Saúde")]
        Higiene = 2,

        [Description("Vestuário")]
        Vestuario = 3,

        [Description("Lazer")]
        Lazer = 4,

        [Description("Habitação")]
        Habitacao = 5
    }
}
