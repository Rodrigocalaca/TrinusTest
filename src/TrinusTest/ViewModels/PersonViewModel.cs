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
                    OnPropertyChanged(nameof(AgeIndentifier));
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

        public AgeIndentifier AgeIndentifier
        {
            get
            {
                if (Age <= 12)
                {
                   return AgeIndentifier.CHILD;
                }
                else if (Age > 12 && Age <= 18)
                {
                    return AgeIndentifier.YOUNG;
                }
                else if (Age > 18 && Age <= 65)
                {
                    return AgeIndentifier.ADULT;
                }
                else
                {
                    return AgeIndentifier.OLD;
                }
            }
        }

        public PersonType PersonType
        {
            get => Model!.PersonType;
            set
            {
                if(Model?.PersonType != null)
                {
                    if (value != Model?.PersonType)
                    {
                        Model!.PersonType = value;
                        if (value == PersonType.Legal)
                        {                        
                            Ssn = null;
                        }
                        else if (value == PersonType.Natural)
                        {;
                            Ssn = null;
                        }
                    }
                }
            }
        }

        protected override void OnValidation()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                ValidationErrors.Add(nameof(Name), "Preencha seu nome");
            }
            if (!Age.HasValue || Age < 0)
            {
                ValidationErrors.Add(nameof(Age), "Preencha sua idade corretamente");
            }
            if (string.IsNullOrEmpty(Ssn))
            {
                ValidationErrors.Add(nameof(Ssn), "Preencha seu CPF");
            }
            //else if(!Ssn.IsValidCPF())
            //{
            //    ValidationErrors.Add(nameof(Ssn), "Por favor insira um CPF válido");
            //}
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
