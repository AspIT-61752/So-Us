namespace SoUs.CareApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        #region Fields

        private string welcomeMessage;

        #endregion

        #region Constructors

        public MainPageViewModel()
        {
            WelcomeMessage = "Welcome to SoUs Care App!";
        }

        #endregion

        #region Properties

        public string WelcomeMessage { get => welcomeMessage; set => SetProperty(ref welcomeMessage, value); }

        #endregion
    }
}
