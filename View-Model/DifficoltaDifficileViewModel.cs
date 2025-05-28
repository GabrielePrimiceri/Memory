using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.X86;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjectWork_Memory.Model;
using ProjectWork_Memory.View;
using ProjectWork_Memory.ViewModel;
using static ProjectWork_Memory.View.DifficoltaDifficile;

namespace ProjectWork_Memory.ViewModel
{
    public partial class DifficoltaDifficileViewModel : ObservableObject
    {
        DifficoltaDifficile difficile;

        Partita partita;

        Button[,] matriceBottoni; 

        public DifficoltaDifficileViewModel()
        {
            

            List<Carta> listacarte = new List<Carta>();

            for (int i = 0; i<16; i++)
            {
                Carta carta = new Carta(i + 1);
                Carta carta2 = new Carta(i + 1);

                //creo due carte doppie alla volta

                listacarte.Add(carta);
                listacarte.Add(carta2);
            }

            partita = new Partita(listacarte);

            difficile = new DifficoltaDifficile();


        }

        // serve un stratagemma per capire quante volte ho eseguito UsaBottone

        int riga1 = 0;
        int colonna1 = 0;

        int riga2 = 0;
        int colonna2 = 0;

        [RelayCommand]
        public void UsaBottone(Button b1)
        {
            string identificativoBottone = b1.CommandParameter as string;
            //serve per ricavare riga e colonna dallo xaml

            string [] stringaDivisa = identificativoBottone.Split('-');
            //dividiamo la stringa

            riga1 = int.Parse(stringaDivisa[0]);
            colonna1 = int.Parse(stringaDivisa[1]);

            

            int valoreCarta1 = partita.RilevaValoreCarta (riga1, colonna1);

            //capire con una variabile se sto premendo il primo o il secondo bottone
            
            //se sto premendo il secondo bottone richiamo partita.controllaCoppia

        }

    }
}