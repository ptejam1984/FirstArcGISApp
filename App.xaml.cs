using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FirstArcGISApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Note: it is not best practice to store API keys in source code.
            // The API key is referenced here for the convenience of this tutorial.
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPKee66d765df27402bbb4299c8dba6be73QT0UkCUjSjURaCjoHaadHkZQHUq5w0Psx7vI0P1V-c-wXz0slmzPqnQuuZ1fXIKJ";
        }

    }
}
