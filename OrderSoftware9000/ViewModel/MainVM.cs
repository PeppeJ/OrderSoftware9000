using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using OrderSoftware9000.Views;

namespace OrderSoftware9000.ViewModel
{
    public class MainVM : ObservableObject
    {
        public MainVM()
        {
            SelectedVM = new StartMenuVM();
        }

        private object _selectedVM;

        private ICommand _openOrderVM;
        public ICommand OrderVM
        {
            get
            {
                if (_openOrderVM == null)
                {
                    _openOrderVM = new RelayCommand(param => SelectedVM = new OrderVM());
                }
                return _openOrderVM;
            }
        }

        private ICommand _openStartVM;
        public ICommand StartMenuVM
        {
            get
            {
                if (_openStartVM == null)
                {
                    _openStartVM = new RelayCommand(param => SelectedVM = new StartMenuVM());
                }
                return _openStartVM;
            }
        }

        private ICommand _openStockVM;
        public ICommand OpenStockVM
        {
            get 
            {
                if (_openStockVM == null)
                {
                    _openStockVM = new RelayCommand(param => SelectedVM = new StockVM());
                }
                return _openStockVM; 
            }
        }

        public object SelectedVM
        {
            get => _selectedVM;
            set
            {
                _selectedVM = value;
                OnPropertyChanged(nameof(SelectedVM));
            }
        }
    }
}
