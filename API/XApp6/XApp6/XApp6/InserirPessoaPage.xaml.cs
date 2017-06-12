using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XApp6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InserirPessoaPage : ContentPage
    {
        Gestor gestor; //referência ao gestor de dados

        public InserirPessoaPage(Gestor _gestor)
        {
            InitializeComponent();
            gestor = _gestor;
        }

        private void btnInserirPessoa_Clicked(object sender, EventArgs e)
        {
            //cria o objeto da pessoa com os dados da interface gráfica
            Pessoa pessoa = new Pessoa(eNome.Text, eMorada.Text, eMail.Text, eGenero.Text, Convert.ToInt32(eIdade.Text));

            //invoca o método de inserção com o objeto como parâmetro
            gestor.InserirPessoa(pessoa);
        }
    }
}