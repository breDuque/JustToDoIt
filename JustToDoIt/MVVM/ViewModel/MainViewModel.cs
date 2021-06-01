using JustToDoIt.Core;

namespace JustToDoIt.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FavoritosViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public FavoritosViewModel FavoritosVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            FavoritosVM = new FavoritosViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            FavoritosViewCommand = new RelayCommand(o =>
            {
                CurrentView = FavoritosVM;
            });


        }
    }
}
