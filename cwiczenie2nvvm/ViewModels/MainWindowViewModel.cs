using cwiczenie2nvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace cwiczenie2nvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private ObservableCollection<Pracownik> _pracownicy;
        
        public ObservableCollection<Pracownik> Pracownicy
        {
            get { return _pracownicy; }

            set
            {
                _pracownicy = value;
                onPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            Pracownicy = new ObservableCollection<Pracownik>();

            Pracownicy.Add(new Pracownik
            {
                imie = "Jan",
                nazwisko = "Kowalski",
                wynagrodzenie = 5000
            });
        }

    }
}
