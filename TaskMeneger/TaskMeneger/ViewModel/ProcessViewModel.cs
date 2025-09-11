using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TaskMeneger.Model;

namespace TaskMeneger.ViewModel;

public class ProcessViewModel : ObservableObject
{
    private ObservableCollection<ProcessModel> _processes =  new ObservableCollection<ProcessModel>();
    private DispatcherTimer _timer;
    
    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set
        {
            SetProperty(ref _searchText, value);
        }
    }
    private ProcessModel _selectedProcess;
    
    public ProcessModel SelectedProcess
    {
        get => _selectedProcess;
        set => SetProperty(ref _selectedProcess, value);
    }
    public ObservableCollection<ProcessModel> Processes
    {
        get => _processes;
        set => SetProperty(ref _processes, value);
    }

    private string _selectedPriority;

    public string SelectedPriority
    {
        get => _selectedPriority;
        set => SetProperty(ref _selectedPriority, value);
    }

    public ProcessViewModel()
    {
        FindProcessCommand = new RelayCommand(FindProcess);
        ProcessKillCommand = new RelayCommand(ProcessKill);
        PrioritySaveCommand = new RelayCommand(PrioritySave);
            
        Processes = new ObservableCollection<ProcessModel>();
        
        _timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(2)
        };
        _timer.Tick += (s, e) => UpdateProcesses();
        _timer.Start();
    }

    private void PrioritySave()
    {
        if (SelectedProcess != null)
        {
            string newPriority = SelectedPriority; 
            var process = Process.GetProcessById(SelectedProcess.Id);
            switch(newPriority)
            {
                case "Low":
                    process.PriorityClass = ProcessPriorityClass.Idle;
                    break;
                case "Below normal":
                    process.PriorityClass = ProcessPriorityClass.BelowNormal;
                    break;
                case "Normal":
                    process.PriorityClass = ProcessPriorityClass.Normal;
                    break;
                case "Above Normal":
                    process.PriorityClass = ProcessPriorityClass.AboveNormal;
                    break;
                case "High":
                    process.PriorityClass = ProcessPriorityClass.High;
                    break;
                case "Real Time":
                    process.PriorityClass = ProcessPriorityClass.RealTime;
                    break;
            }
        }
    }

    private void ProcessKill()
    {
        var processes = Process.GetProcesses();

        foreach (var process in processes)
        {
            if (process.ProcessName == SelectedProcess.Name)
            {
                process.Kill();
            }
        }
    }

    private void FindProcess()
    {
        SelectedProcess = null; 

        foreach (var p in Processes)
        {
            if (p.Name == _searchText)
            {
                SelectedProcess = p;
                break; 
            }
        }
    }



    public ICommand FindProcessCommand { get; }
    public ICommand ProcessKillCommand { get; }
    public ICommand PrioritySaveCommand { get; }
    
    private void UpdateProcesses()
    {
        var currentProcesses = Process.GetProcesses();
        
        for (int i = Processes.Count - 1; i >= 0; i--)
        {
            if (!currentProcesses.Any(p => p.Id == Processes[i].Id))
                Processes.RemoveAt(i);
        }

        foreach (var p in currentProcesses)
        {
            var existing = Processes.FirstOrDefault(x => x.Id == p.Id);

            if (existing != null)
            {
                existing.Memory = p.WorkingSet64.ToString("#,##0");
                existing.Status = p.Responding;
                existing.Priority = p.BasePriority.ToString();
            }
            else
            {
                Processes.Add(new ProcessModel
                {
                    Id = p.Id,
                    Name = p.ProcessName,
                    Priority = p.BasePriority.ToString(),
                    Memory = p.WorkingSet64.ToString("#,##0"),
                    Status = p.Responding
                });
            }
        }
    }

    
    
    

}