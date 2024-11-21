using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views.Lesson02
{
    public partial class MultiBindingStringFormatPage : ContentPage
    {
        public MultiBindingStringFormatPage()
        {
            InitializeComponent();

            BindingContext = new GroupViewModel();
        }
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }
    }
}
