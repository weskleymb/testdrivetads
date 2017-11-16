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
    public partial class Agendamento : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public Agendamento(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            BindingContext = this;
        }
    }
}