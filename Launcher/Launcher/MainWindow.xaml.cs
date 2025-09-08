using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void RunButton_Click(object sender, RoutedEventArgs e)
    {
        string argument = ExpressionTextBox.Text;
        
        var startInfo = new ProcessStartInfo
        {
            FileName = @"C:\Users\farid\RiderProjects\Launcher\Calc\bin\Debug\net9.0\Calc.exe",
            Arguments = $"\"{argument}\"",
        };
        
        Process.Start(startInfo);
        this.Hide();
    }
}