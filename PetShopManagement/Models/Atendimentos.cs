using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopManagement.Models
{
    public class Atendimentos
    {
        #region Propriedades
        public int Id { get; set; }
        public DateTime DataAtendimento { get; set; }
        public double ValorTotal { get; set; }
        public Funcionario Funcionario { get; set; }
        public Animal Animal { get; set; }

        public List<Servicos> Servicos { get; set; } = new List<Servicos>();
        public List<Produtos> Produtos { get; set; } = new List<Produtos>();
        #endregion

        #region Construtores
        public Atendimentos()
        {

        }
        public Atendimentos(int id, DateTime dataAtendimento, double valorTotal, Funcionario funcionario, Animal animal)
        {
            Id = id;
            DataAtendimento = dataAtendimento;
            ValorTotal = valorTotal;
            Funcionario = funcionario;
            Animal = animal;
        }
        #endregion

        #region Métodos Públicos
        public Funcionario AtribuirFuncionario(Funcionario funcionario)
        {          
            return this.Funcionario = funcionario;
        }

        public Animal AdicionarAnimal(Animal animal)
        {
           return this.Animal = animal;
        }

        public void AdicionarServicos(Servicos servicos)
        {
            this.Servicos.Add(servicos);
        }

        public void AdicionarProdutos(Produtos produtos)
        {
            this.Produtos.Add(produtos);
        }
        #endregion
    }
}
