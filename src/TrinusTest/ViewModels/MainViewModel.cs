using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TrinusTest.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public ObservableCollection<PersonViewModel> Users { get; set; } = new ObservableCollection<PersonViewModel>();
        
        public ICommand? RegisterCommand { get; set; }
        
        public ICommand? EditCommand { get; set; }

        public ICommand? DeleteCommand { get; set; }

        private PersonViewModel? _currentUser;

        public PersonViewModel? CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

    }
}
