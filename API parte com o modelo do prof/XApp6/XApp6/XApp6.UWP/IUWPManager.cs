using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

[assembly: Xamarin.Forms.Dependency(typeof(XApp6.UWP.IUWPManager))]
namespace XApp6.UWP
{
    class IUWPManager : IGeral
    {
        public void CloseApplication()
        {
            Application.Current.Exit();
        }
    }
}
