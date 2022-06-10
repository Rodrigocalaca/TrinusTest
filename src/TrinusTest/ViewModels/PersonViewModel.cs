using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinusTest.Models.People;

namespace TrinusTest.ViewModels
{
    public class PersonViewModel : BindableBase
    {
        public Person? Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged(null);
            }
        }

        private Person? _model;

        public string? Name
        {
            get => Model?.Name;
            set
            {
                if (Model?.Name != value)
                {
                    Model!.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int? Age
        {
            get => Model?.Age;
            set
            {
                if(Model?.Age != value)
                {
                    Model!.Age = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? Ssn
        {
            get => Model?.Ssn;
            set
            {
                if(Model?.Ssn != value)
                {
                    Model!.Ssn = value;
                    OnPropertyChanged();
                }
            }
        }
        public PersonViewModel()
        {
            Model = new Person();
            IsNewEntry = true;
        }

        public PersonViewModel(Person? person)
        {
            if (person != null)
            {
                Model = person;
            }
        }
    }
}
