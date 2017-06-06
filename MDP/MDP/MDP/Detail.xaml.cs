using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            //InitializeComponent();

            var fundo = new Image { Aspect = Aspect.AspectFit };
            fundo.Source = ImageSource.FromFile("REC06830.jpg");

            fundo.Source = Device.OnPlatform(
                iOS: ImageSource.FromFile("Resources/REC06830.jpg"),
                Android: ImageSource.FromFile("Resources/REC06830.jpg"),
                WinPhone: ImageSource.FromFile("Resources/REC06830.jpg")
            );
        }
    }
}