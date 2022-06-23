using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrinusTest.ViewModels
{
    public class BindableBase : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// The error message to display on the view.
        /// </summary>
        public string Error
        {
            get
            {
                int actual = ValidationErrors.ContainsKey(nameof(ValidationContext)) ? ValidationErrors.Count - 1 : ValidationErrors.Count;
                if (actual > 0)
                {
                    return $"{actual} erro{(actual == 1 ? "" : "s")} encontrado{(actual == 1 ? "" : "s")}";
                }
                return null;
            }
        }

        [IndexerName("Item")]
        /// <summary>
        /// The property used to store validation errors.
        /// </summary>
        /// <param name="columnName">The name of the property</param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get
            {
                if (ValidationErrors.ContainsKey(columnName))
                {
                    return ValidationErrors[columnName];
                }
                return null;
            }
        }

        /// <summary>
        /// A dictionary containing properties with validation errors and their error messages.
        /// </summary>
        public Dictionary<string, string> ValidationErrors = new Dictionary<string, string>();

        public object ValidationContext { get; set; }

        /// <summary>
        /// A method that validates property values.
        /// </summary>
        protected virtual void OnValidation() { }

        /// <summary>
        /// Validates properties and checks for errors.
        /// </summary>
        /// <returns>True if errors are found.</returns>
        public bool HasErrors
        {
            get
            {
                ValidationErrors.Clear();
                OnValidation();
                //updates all properties on front-end.
                if (ValidationErrors.Count > 0)
                {
                    ValidationErrors.Add(nameof(ValidationContext), "Possui erros");
                    OnPropertyChanged(string.Empty);
                }
                else OnPropertyChanged(nameof(Error));
                return ValidationErrors.Count > 0;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners. This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="CallerMemberNameAttribute"/>.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            if (propertyName != null && this[propertyName] != null && propertyName != nameof(ValidationContext))
            {
                ValidationErrors.Remove(propertyName);
                if (ValidationErrors.Count == 1 && ValidationErrors.ContainsKey(nameof(ValidationContext)))
                {
                    ValidationErrors.Clear();
                }
                OnPropertyChanged(nameof(ValidationContext));
                OnPropertyChanged(nameof(Error));
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T storage, T value,
            [CallerMemberName] string? propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }


        private bool _isNewEntry;
        
        public bool IsNewEntry { get => _isNewEntry; set => Set(ref _isNewEntry, value); }

        private bool _isEditing;

        public bool IsEditing { get => _isEditing; set => Set(ref _isEditing, value); }
    }
}
