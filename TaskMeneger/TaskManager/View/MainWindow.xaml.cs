using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using TaskManager.ViewModel;
using TaskManager.Model;

namespace TaskManager.View;

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
    private void MyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (TasksList.SelectedItem != null)
            TasksList.ScrollIntoView(TasksList.SelectedItem);
    }
}