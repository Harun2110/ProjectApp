using CobaProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaProject.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DestinationViewCommand { get; set; }
        public RelayCommand MapsViewCommand { get; set; }
        public RelayCommand SouvenirViewCommand { get; set; }
        public RelayCommand TransactionViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DestinationViewModel DestinationVM { get; set; }
        public MapsViewModel MapsVM { get; set; }
        public SouvenirViewModel SouvenirVM {  get; set; }
        public TransactionViewModel TransactionVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        { 
            HomeVM = new HomeViewModel();
            DestinationVM = new DestinationViewModel();
            MapsVM = new MapsViewModel();
            SouvenirVM = new SouvenirViewModel();
            TransactionVM = new TransactionViewModel();
            SettingsVM = new SettingsViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DestinationViewCommand = new RelayCommand(o => {
                CurrentView = DestinationVM;
            });

            MapsViewCommand = new RelayCommand(o =>
            {
                CurrentView = MapsVM;
            });

            SouvenirViewCommand = new RelayCommand(o =>
            {
                CurrentView = SouvenirVM;
            });

            TransactionViewCommand = new RelayCommand(o =>
            {
                CurrentView = TransactionVM;
            });

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
        }
    }
}
