using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models.ViewModels
{
    public class FuncionarioViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Atendimentos> Atendimentos { get; set; }


    }
}
