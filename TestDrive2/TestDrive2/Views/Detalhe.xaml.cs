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
                DisplayAlert("Teste", "Mudou: " + temArCondicionado, "OK");
                Veiculo.Preco += 1500;
                OnPropertyChanged(nameof(temArCondicionado));
            }
        }

        private string valorFinal;
        public string ValorFinal
        {
            get
            {
                return valorFinal;
            }
            set
            {
                valorFinal = value;
                if (temArCondicionado)
                {
                    valorFinal = string.Format("Preço total: {0}", Veiculo.Preco + 1500);
                } else
                {
                    valorFinal = string.Format("Preço total: {0}", Veiculo.Preco - 1500);
                }
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