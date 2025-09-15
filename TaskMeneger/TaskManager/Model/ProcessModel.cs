using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskManager.Model
{
    public class ProcessModel : ObservableObject
    {
        private string? _name;
        public string? Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _priority;
        public string Priority
        {
            get => _priority;
            set => SetProperty(ref _priority, value);
        }

        private bool _status;
        public bool Status
        {
            get => _status;
            set => SetProperty(ref _status, value);
        }

        private string _memory;
        public string Memory
        {
            get => _memory;
            set => SetProperty(ref _memory, value);
        }
    }
}