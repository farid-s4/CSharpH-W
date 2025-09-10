using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gma.System.MouseKeyHook;
using static F1ScreenBindWpf.ScreenShotServices;
using MessageBox = System.Windows.MessageBox;

namespace F1ScreenBindWpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private NotifyIcon _trayIcon;
    private IKeyboardMouseEvents _globalHook;
    
    public MainWindow()
    {
        InitializeComponent();
        SetupGlobalHotkey();
        Hide();
    }
    
    private void SetupGlobalHotkey()
    {
        _globalHook = Hook.GlobalEvents();
        _globalHook.KeyDown += (sender, e) =>
        {
            if (e.KeyCode == Keys.F1)
            {
                int result = CaptureScreenToPNG(DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                MessageBox.Show("Screenshot captured successfully");
            }
        };
    }
    
    
    protected override void OnStateChanged(EventArgs e)
    {
        base.OnStateChanged(e);

        if (WindowState == WindowState.Minimized)
            Hide();
    }
    
}