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
        private string _nImie;
        private string _nNazwisko;
        private float _nPensja;

        public ObservableCollection<Pracownik> Pracownicy
        {
            get { return _pracownicy; }

            set
            {
                _pracownicy = value;
                onPropertyChanged();
            }
        }

        public string nImie
        {
            get { return _nImie; }
            set { _nImie = value; onPropertyChanged(); }
        }

        public string nNazwisko
        {
            get { return _nNazwisko; }
            set { _nNazwisko = value; onPropertyChanged(); }
        }

        public float nPensja
        {
            get { return _nPensja; }
            set { _nPensja = value; onPropertyChanged(); }
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
            Pracownicy.Add(new Pracownik
            {
                imie = "Adam",
                nazwisko = "Nowak",
                wynagrodzenie = 6000
            });
        }

        private void dodajPracownika()
        {
            Pracownicy.Add(new Pracownik()
            {
                imie = nImie,
                nazwisko = nNazwisko,
                wynagrodzenie = nPensja

            });

        }

    }
}
