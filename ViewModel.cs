using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Anuita
{
    public class ViewModel : ViewModelBase
    {
        private double anuita;
        private double urokovka;

        public double RocniUrokProcenta{ get; set; }
        public double PocatecniHodnotaDluhu { get; set; }
        public double PocetLetSplatek { get; set; }

        public Command CommandUrokovka { get; set; }
        public double Urokovka { get => urokovka; set { urokovka = value; OnPropertyChanged(nameof(Urokovka)); } }

        public Command CommandAnuita { get; set; }

        public double Anuita { get => anuita; set { anuita = value; OnPropertyChanged(nameof(Anuita)); } }

        public ViewModel()
        {

            CommandUrokovka = new Command(() => Urokovka = 1 / (1 + (RocniUrokProcenta / (12*100))));
            CommandAnuita = new Command(() => Anuita = ((RocniUrokProcenta / (12 *100)) * PocatecniHodnotaDluhu) / (1 - Math.Pow(Urokovka, (PocetLetSplatek*12))));

        }


    }
}


