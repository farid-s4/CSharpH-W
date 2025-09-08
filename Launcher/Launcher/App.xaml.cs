using System.Configuration;
using System.Data;
using System.Windows;

namespace Launcher;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private Mutex _appMutex;

    protected override void OnStartup(StartupEventArgs e)
    {
        string _mutexName = "Launcher";
        
        bool createdNew = false;
        _appMutex = new Mutex(true, _mutexName, out createdNew);

        if (!createdNew)
        {
            MessageBox.Show("Another instance of this application is already running.");
            Shutdown();
            return;
        }
        base.OnStartup(e);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        if  (_appMutex != null)
            _appMutex.Dispose();
        base.OnExit(e);
    }
}