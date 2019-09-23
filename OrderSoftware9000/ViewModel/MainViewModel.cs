using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using OrderSoftware9000.Views;

namespace OrderSoftware9000.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            SelectedViewModel = new StartMenuViewModel();
        }

        private object _selectedViewModel;

        private ICommand _openOrderView;
        public ICommand OrderViewModel
        {
            get
            {
                if (_openOrderView == null)
                {
                    _openOrderView = new RelayCommand(param => SelectedViewModel = new OrderViewModel());
                }
                return _openOrderView;
            }
        }

        private ICommand _openStartMenuView;
        public ICommand StartMenuViewModel
        {
            get
            {
                if (_openStartMenuView == null)
                {
                    _openStartMenuView = new RelayCommand(param => SelectedViewModel = new StartMenuViewModel());
                }
                return _openStartMenuView;
            }
        }

        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
    }
}
