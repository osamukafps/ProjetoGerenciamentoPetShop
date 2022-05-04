using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models.ViewModels
{
    public class AtendimentoFormViewModelSaida
    {
        public DateTime DataAtendimento { get; set; }
        public int idFuncionario { get; set; }
        public double ValorTotal { get; set; }
        public int idAnimal { get; set; }


    }
}
