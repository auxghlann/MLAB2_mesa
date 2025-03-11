using System.Collections.ObjectModel;

namespace MLAB2_mesa
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            ItemsListView.ItemsSource = Items;
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ItemEntry.Text))
            {
                Items.Add(ItemEntry.Text);
                ItemEntry.Text = string.Empty;
            }
                
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Items.Remove(e.SelectedItem.ToString());
            }
        }
    }

}
