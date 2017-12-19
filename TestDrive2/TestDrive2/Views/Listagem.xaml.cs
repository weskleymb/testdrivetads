using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using TestDrive2.Models;
using Xamarin.Forms;

namespace TestDrive2.Views
{
    public partial class Listagem : ContentPage
    {

        const string URL_GET_VEICULOS = "http://aluracar.herokuapp.com";

        public ObservableCollection<Veiculo> Veiculos { get; set; }

        public Listagem()
        {
            InitializeComponent();
            this.Veiculos = new ObservableCollection<Veiculo>();
            this.BindingContext = this;
            GetVeiculos();
        }

        private void listagemVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Veiculo veiculo = (Veiculo)e.Item;
            Navigation.PushAsync(new Detalhe(veiculo));
        }

        public async void GetVeiculos()
        {
            HttpClient cliente = new HttpClient();
            var resultado = await cliente.GetStringAsync(URL_GET_VEICULOS);

            var veiculosJson = JsonConvert.DeserializeObject<VeiculoJson[]>(resultado);
            foreach (var veiculoJson in veiculosJson)
            {
                this.Veiculos.Add(new Veiculo(veiculoJson.nome, veiculoJson.preco));
            }
        }
    }

    class VeiculoJson
    {
        public string nome { get; set; }
        public decimal preco { get; set; }
    }
}