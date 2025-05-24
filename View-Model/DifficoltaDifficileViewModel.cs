using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjectWork_Memory.Model;
using ProjectWork_Memory.ViewModel;

namespace ProjectWork_Memory.ViewModel
{
    public partial class DifficoltaDifficileViewModel : ObservableObject
    {
        public DifficoltaDifficileViewModel()
        {
            Button[,] _matriceBottni = new Button[4,8];
            GestoreMatrice gestore = new GestoreMatrice(4, 8);
            Carta c1 = new Carta(1);
            Carta c2 = new Carta(2);
            Carta c3 = new Carta(3);
            Carta c4 = new Carta(4);
            Carta c5 = new Carta(5);
            Carta c6 = new Carta(6);
            Carta c7 = new Carta(7);
            Carta c8 = new Carta(8);
            Carta c9 = new Carta(9);
            Carta c10 = new Carta(10);
            Carta c11 = new Carta(11);
            Carta c12 = new Carta(12);
            Carta c13 = new Carta(13);
            Carta c14 = new Carta(14);
            Carta c15 = new Carta(15);
            Carta c16 = new Carta(16);
            
            Carta d1 = new Carta(1);
            Carta d2 = new Carta(2);
            Carta d3 = new Carta(3);
            Carta d4 = new Carta(4);
            Carta d5 = new Carta(5);
            Carta d6 = new Carta(6);
            Carta d7 = new Carta(7);
            Carta d8 = new Carta(8);
            Carta d9 = new Carta(9);
            Carta d10 = new Carta(10);
            Carta d11 = new Carta(11);
            Carta d12 = new Carta(12);
            Carta d13 = new Carta(13);
            Carta d14 = new Carta(14);
            Carta d15 = new Carta(15);
            Carta d16 = new Carta(16);

            gestore.InserisciCarte(c1);
            gestore.InserisciCarte(c2);
            gestore.InserisciCarte(c3);
            gestore.InserisciCarte(c4);
            gestore.InserisciCarte(c5);
            gestore.InserisciCarte(c6);
            gestore.InserisciCarte(c7);
            gestore.InserisciCarte(c8);
            gestore.InserisciCarte(c9);
            gestore.InserisciCarte(c10);
            gestore.InserisciCarte(c11);
            gestore.InserisciCarte(c12);
            gestore.InserisciCarte(c13);
            gestore.InserisciCarte(c14);
            gestore.InserisciCarte(c15);
            gestore.InserisciCarte(c16);
       
            gestore.InserisciCarte(d1);
            gestore.InserisciCarte(d2);
            gestore.InserisciCarte(d3);
            gestore.InserisciCarte(d4);
            gestore.InserisciCarte(d5);
            gestore.InserisciCarte(d6);
            gestore.InserisciCarte(d7);
            gestore.InserisciCarte(d8);
            gestore.InserisciCarte(d9);
            gestore.InserisciCarte(d10);
            gestore.InserisciCarte(d11);
            gestore.InserisciCarte(d12);
            gestore.InserisciCarte(d13);
            gestore.InserisciCarte(d14);
            gestore.InserisciCarte(d15);
            gestore.InserisciCarte(d16);

        }

        
        [RelayCommand]
        public async Task UsaBottone(Button b1)
        {
          b1.Content
        }
    }
}
