using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XApp6.Controller;

namespace XApp6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaFriendsPage : ContentPage
    {
        FriendController friends;
        private string teste;

        public ListaFriendsPage(FriendController _friends)
        {
            InitializeComponent();

            friends = _friends;
            exemplo.ItemsSource = friends.ListaFriends; //adiciona os objetos à listview
        }
    }
}