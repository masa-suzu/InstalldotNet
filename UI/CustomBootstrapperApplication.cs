using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
using System.Windows.Threading;

namespace Install.Net.UI
{

    public class CustomBootstrapperApplication : BootstrapperApplication
    {
        protected override void Run()
        {
            var dispatcher = Dispatcher.CurrentDispatcher;
            var w = new MainWindow();
            w.Closed += (_, __) => dispatcher.InvokeShutdown();

            w.Show();
            Dispatcher.Run();
            Engine.Quit(0);
        }
    }
}
