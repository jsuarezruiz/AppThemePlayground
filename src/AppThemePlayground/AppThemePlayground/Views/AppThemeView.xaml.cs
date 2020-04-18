using Xamarin.Forms;

namespace AppThemePlayground.Views
{
    public partial class AppThemeView : ContentPage
    {
        public AppThemeView()
        {
            InitializeComponent();

            Application.Current.RequestedThemeChanged += OnRequestedThemeChanged; 
        }

        void OnRequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            AppTheme requestedTheme = e.RequestedTheme;
            ThemeLabel.Text = requestedTheme.ToString();
        }
    }
}