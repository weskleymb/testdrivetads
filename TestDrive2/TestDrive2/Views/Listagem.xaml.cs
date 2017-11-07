using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive2.Views
{
    public partial class Listagem : ContentPage
    {

        public List<Veiculo> Veiculos { get; set; }

        public Listagem()
        {
            InitializeComponent();
            Veiculos = new List<Veiculo>
            {
                new Veiculo("HB 20", 40000),
                new Veiculo("Honda Civic", 70000),
                new Veiculo("Pajero TR4", 35000),
                new Veiculo("Gol Bola", 18000)
            };
            this.BindingContext = this;
        }

        private void listagemVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Veiculo veiculo = (Veiculo)e.Item;
            Navigation.PushAsync(new Detalhe(veiculo));
        }
    }
}