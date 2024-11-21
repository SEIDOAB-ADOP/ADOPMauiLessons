using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views
{

    public partial class Lesson06c : ContentPage
    {
        public Lesson06c()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson06cViewModel pageData = args.SelectedItem as Lesson06cViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                //await Navigation.PushAsync(page);
                await Shell.Current.GoToAsync(pageData.Route);
            }
        }
    }
}