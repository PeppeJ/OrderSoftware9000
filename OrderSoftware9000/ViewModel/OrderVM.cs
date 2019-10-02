using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OrderSoftware9000.Models;
using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.ViewModel
{
    public class OrderVM : ObservableObject
    {
        private OrderModel _selectedOrder;

        public OrderModel SelectedOrder
        {
            get => _selectedOrder;
            set => _selectedOrder = value;
        }

        public double OrderCost => SelectedOrder.Cost;

        public IEnumerable<IProduct> OrderedMeals => SelectedOrder.Meals;
        //public IEnumerable<IMeal> AvailableMeals => ;
    }
}
