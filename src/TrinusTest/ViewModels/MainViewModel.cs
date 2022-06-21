﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TrinusTest.Models.People;
using TSOriginação;

namespace TrinusTest.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public ObservableCollection<PersonViewModel> Users { get; set; } = new ObservableCollection<PersonViewModel>();

        public ICommand? RegisterCommand { get; set; }

        public ICommand? EditCommand { get; set; }

        public ICommand? DeleteCommand { get; set; }

        public string? ActionLabel { get { return CurrentUser!.IsEditing ? "Confirmar" : "Registrar"; } }

        private PersonViewModel? _currentUser;

        public PersonViewModel? CurrentUser
        {
            get => _currentUser;
            set => Set(ref _currentUser, value);
        }

        public MainViewModel()
        {
            CurrentUser = new PersonViewModel();
            RegisterCommand = new RelayCommand(Register);
            EditCommand = new RelayCommand<PersonViewModel>(Edit);
            DeleteCommand = new RelayCommand<PersonViewModel>(Delete);
        }

        

        public void Register()
        {
            if (CurrentUser != null)
            {
                if (CurrentUser.IsNewEntry)
                {
                    Users.Add(CurrentUser);
                    
                    CurrentUser.IsNewEntry = false;
                    CurrentUser = new PersonViewModel();
                    
                }
                else if (CurrentUser.IsEditing)
                {
                    
                    CurrentUser.IsEditing = false;
                    CurrentUser = new PersonViewModel();
                }
            }
            OnPropertyChanged(nameof(ActionLabel));
        }

        public void Edit(PersonViewModel person)
        {
            CurrentUser = person;
            CurrentUser.IsEditing = true;
            OnPropertyChanged(nameof(ActionLabel));
        }

        public void Delete(PersonViewModel person)
        {
            Users.Remove(person);
        }
    }
}
