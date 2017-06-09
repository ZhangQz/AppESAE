using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XApp6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPessoasPage : ContentPage
    {
        Gestor gestor;

        public ListaPessoasPage(Gestor _gestor)
        {
            InitializeComponent();
            gestor = _gestor;

            listapessoas.ItemsSource = gestor.GetAllItens();
        }

        private void listapessoas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine(e.SelectedItem.ToString());
            DisplayAlert("Janela de Alerta","O item selecionado foi: "+e.SelectedItem.ToString(), "ok");
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
