using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models.ViewModels
{
    public class AtendimentoFormViewModel
    {
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Servicos> Servicos { get; set; }
        public ICollection<Produtos> Produtos { get; set; }
        public ICollection<Animal> Animal { get; set; }

        [Display(Name = "Funcionário")]
        public int IdFuncionario { get; set; }
        [Display(Name = "Serviços")]
        public List<int> IdServico { get; set; }
        [Display(Name = "Produtos")]
        public int IdProduto { get; set; }
        [Display(Name = "Animal")]
        public int IdAnimal { get; set; }

        [Display (Name = "Valor Total")]
        public double ValorTotal { get; set; }
        [Display(Name ="Data do Atendimento")]
        public DateTime DataAtendimento { get; set; }
    }
}
