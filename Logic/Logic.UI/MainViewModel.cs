using GalaSoft.MvvmLight;

namespace UI.Desktop.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "MvvmSample (Design)";
            }
            else
            {
                WindowTitle = "MvvmSample ";
            }
        }
        public string WindowTitle { get; private set; }
    }
}