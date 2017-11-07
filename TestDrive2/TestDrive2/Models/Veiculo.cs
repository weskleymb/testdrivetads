using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive2.Models
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Veiculo(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Nome, Preco);
        }
    }
}
