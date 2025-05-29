using CommunityToolkit.Mvvm.Input;
using ProjectWork_Memory.ViewModel;
using ProjectWork_Memory.Model;
using System.Reflection.Metadata;

namespace ProjectWork_Memory.View;

public partial class DifficoltaDifficile : ContentPage
{
    bool primoClickEffettuato = false;

    Partita partita;

    Button[,] matriceBottoni;

    public DifficoltaDifficile()
    {
        InitializeComponent();

        List<Carta> listacarte = new List<Carta>();

        for (int i = 0; i < 16; i++)
        {
            Carta carta = new Carta(i + 1);
            Carta carta2 = new Carta(i + 1);

            //creo due carte doppie alla volta  
            listacarte.Add(carta);
            listacarte.Add(carta2);
        }

        partita = new Partita(listacarte);

        // Inizializza matriceBottoni  
        matriceBottoni = new Button[8, 4];
        matriceBottoni[0, 0] = b1;
        matriceBottoni[0, 1] = b2;
        matriceBottoni[0, 2] = b3;
        matriceBottoni[0, 3] = b4;

        matriceBottoni[1, 0] = b5;
        matriceBottoni[1, 1] = b6;
        matriceBottoni[1, 2] = b7;
        matriceBottoni[1, 3] = b8;

        matriceBottoni[2, 0] = b9;
        matriceBottoni[2, 1] = b10;
        matriceBottoni[2, 2] = b11;
        matriceBottoni[2, 3] = b12;

        matriceBottoni[3, 0] = b13;
        matriceBottoni[3, 1] = b14;
        matriceBottoni[3, 2] = b15;
        matriceBottoni[3, 3] = b16;

        matriceBottoni[4, 0] = b17;
        matriceBottoni[4, 1] = b18;
        matriceBottoni[4, 2] = b19;
        matriceBottoni[4, 3] = b20;

        matriceBottoni[5, 0] = b21;
        matriceBottoni[5, 1] = b22;
        matriceBottoni[5, 2] = b23;
        matriceBottoni[5, 3] = b24;

        matriceBottoni[6, 0] = b25;
        matriceBottoni[6, 1] = b26;
        matriceBottoni[6, 2] = b27;
        matriceBottoni[6, 3] = b28;

        matriceBottoni[7, 0] = b29;
        matriceBottoni[7, 1] = b30;
        matriceBottoni[7, 2] = b31;
        matriceBottoni[7, 3] = b32;

    }

    int riga1 = 0;
    int colonna1 = 0;

    int riga2 = 0;
    int colonna2 = 0;
    int contatoreCoppie = 0;
    public async void UsaBottone(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            Button bottoneCliccato = sender as Button;
            string identificativoBottone = bottoneCliccato.CommandParameter as string;

            string[] stringaDivisa = identificativoBottone.Split('-');
            int riga = int.Parse(stringaDivisa[0]);
            int colonna = int.Parse(stringaDivisa[1]);

            int valoreCarta = partita.RilevaValoreCarta(riga, colonna);

            // Aggiungiamo una variabile per determinare se è il primo o secondo bottone  
            if (!primoClickEffettuato)
            {
                riga1 = riga;
                colonna1 = colonna;

                // Esegui azioni sul primo bottone: es. mostra valore  
                bottoneCliccato.Text = valoreCarta.ToString();
                matriceBottoni[riga1, colonna1].IsEnabled = false;
                bottoneCliccato.TextColor = Colors.Black;

                primoClickEffettuato = true;
            }
            else
            {
                riga2 = riga;
                colonna2 = colonna;

                // Esegui azioni sul secondo bottone: es. mostra valore  
                bottoneCliccato.Text = valoreCarta.ToString();
                bottoneCliccato.TextColor = Colors.Black;
                matriceBottoni[riga2, colonna2].IsEnabled = false;

                // Chiamo ControllaCoppia  
                bool sonoUguali = partita.ControllaCoppia(riga1, colonna1, riga2, colonna2);

                if (!sonoUguali)
                {
                    matriceBottoni[riga1, colonna1].Text = "";
                    await Task.Delay(500); // Aspetta un secondo prima di nascondere i bottoni
                    matriceBottoni[riga2, colonna2].Text = "";
                    matriceBottoni[riga1, colonna1].IsEnabled = true;
                    matriceBottoni[riga2, colonna2].IsEnabled = true;
                }
                else if (sonoUguali)
                {
                    contatoreCoppie += 2;
                    if (contatoreCoppie == 32)
                    {
                        await DisplayAlert("Complimenti!", "Hai vinto la partita!", "OK");
                    }
                }


                primoClickEffettuato = false; // Resetta per il prossimo turno
            }
        }

    }
}
