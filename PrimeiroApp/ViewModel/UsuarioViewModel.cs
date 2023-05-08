using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroApp.ViewModel
{
    internal class UsuarioViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String name = string.Empty;//CTRL + R,E getter setter
        public String DisplayName => $"Nome digitado : {Name}";

        public string Name
        {
            get => name;
            set
            {
                if (name == null)
                    return;

                name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(DisplayName));
            }
        }//CTRL + K,D IDENTAR
    }
}
