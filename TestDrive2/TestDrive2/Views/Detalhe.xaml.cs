using System;
using TestDrive2.Models;
using Xamarin.Forms;

namespace TestDrive2.Views
{
    public partial class Detalhe : ContentPage
    {

        public Veiculo Veiculo { get; set; }

        private Boolean temArCondicionado;
        public Boolean TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged(nameof(ValorFinal));
            }
        }

        private decimal valorFinal;
        public decimal ValorFinal
        {
            get
            {
                if (temArCondicionado)
                {
                    valorFinal = Veiculo.Preco + 1000;
                }
                else
                {
                    valorFinal = Veiculo.Preco;
                }
                return valorFinal;
            }
        }

        public Detalhe(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;

            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Agendamento(Veiculo));
        }
    }
}