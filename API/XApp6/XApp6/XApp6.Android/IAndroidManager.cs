using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly:Xamarin.Forms.Dependency(typeof(XApp6.Droid.IAndroidManager))]
namespace XApp6.Droid
{
    public class IAndroidManager : IGeral
    {
        public void CloseApplication()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}