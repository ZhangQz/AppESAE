using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.Threading;

[assembly: Xamarin.Forms.Dependency(typeof(XApp6.iOS.IiOSManager))]
namespace XApp6.iOS
{
    class IiOSManager : IGeral
    {
        public void CloseApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}