using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using TaskMeneger.Model;
using TaskMeneger.ViewModel;

namespace TaskMeneger.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ProcessViewModel();
    }
}