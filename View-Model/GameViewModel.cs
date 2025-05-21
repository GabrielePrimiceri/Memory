using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ProjectWork_Memory.Model;

namespace ProjectWork_Memory.ViewModel
{
    public class DifficoltaDifficileViewModel : BindableObject
    {
        private GestoreMatrice _gestoreMatrice;
        private Giocatore _giocatore;
        private ObservableCollection<ObservableCollection<Button>> _gameGrid;
        private Carta _firstSelectedCarta;
        private bool _isBusy;

        public ObservableCollection<ObservableCollection<Button>> GameGrid
        {
            get => _gameGrid;
            set
            {
                _gameGrid = value;
                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public DifficoltaDifficileViewModel()
        {
            _gestoreMatrice = new GestoreMatrice(8, 4); // 8 rows, 4 columns
            _giocatore = new Giocatore { GestoreMatrice = _gestoreMatrice };
            _gameGrid = new ObservableCollection<ObservableCollection<Button>>();

            // Initialize the game grid
            InitializeGameGrid();
            SetupGame();
        }

        private void InitializeGameGrid()
        {
            for (int i = 0; i < 8; i++)
            {
                var row = new ObservableCollection<Button>();
                for (int j = 0; j < 4; j++)
                {
                    row.Add(new Button {});
                }
                _gameGrid.Add(row);
            }
        }

        private void SetupGame()
        {
            // Initialize the cards with pairs
            var allCards = new List<Carta>();
            for (int i = 1; i <= 16; i++)
            {
                allCards.Add(new Carta(i));
                allCards.Add(new Carta(i)); // Add pair for each card
            }

            // Shuffle the cards
            var random = new Random();
            allCards = allCards.OrderBy(x => random.Next()).ToList();

            // Insert shuffled cards into the game grid
            for (int row = 0; row < _gestoreMatrice.MatriceCarte.GetLength(0); row++)
            {
                for (int col = 0; col < _gestoreMatrice.MatriceCarte.GetLength(1); col++)
                {
                    var card = allCards.First();
                    allCards.RemoveAt(0);
                    _gestoreMatrice.MatriceCarte[row, col] = card;
                }
            }
        }

        public async Task CardTapped(int row, int col)
        {
            if (_isBusy) return;

            // Flip the card and check for a match
            var carta = _giocatore.ScegliCarta(row, col);

            // Update UI
            GameGrid[row][col].Text = carta.Numero.ToString();

            // Check for match if it's the first card selected
            if (_firstSelectedCarta == null)
            {
                _firstSelectedCarta = carta;
                return;
            }

            if (_firstSelectedCarta.Equals(carta))
            {
                // Match found, remove the pair from the grid
                _gestoreMatrice.MatriceCarte[row, col] = null;
                _gestoreMatrice.MatriceCarte[_firstSelectedCarta.Numero, col] = null; // Update the first selected card as well.
            }
            else
            {
                // Not a match, flip back after a small delay
                IsBusy = true;
                await Task.Delay(500);
                GameGrid[row][col].Text = "?";
                GameGrid[_firstSelectedCarta.Numero][col].Text = "?"; // Reset the first card
                _firstSelectedCarta = null;
                IsBusy = false;
            }
        }
    }
}