using System.Collections.ObjectModel;

namespace sema
{
    public class Performance
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Genres { get; set; }
        public string? ImageUrl { get; set; }
    }


    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Performance> Performances { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Performances = new ObservableCollection<Performance>
        {
            new Performance { Title = "Приключение Алисы в стране чудес", Rating = "5.0", Genres = "Комедия", ImageUrl = "alice.jpg" },
            new Performance { Title = "Подводная лодка", Rating = "5.0", Genres = "Драма", ImageUrl = "das_boot.jpg" }
        };
            PerformancesList.ItemsSource = Performances; // Привязка коллекции к CollectionView
        }


        private void OnCounterClicked(object sender, EventArgs e)
        {
            /*
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            */
        }
    }

}
