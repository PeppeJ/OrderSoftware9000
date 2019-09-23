using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OrderSoftware9000.Models;
using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.ViewModel
{
    public class OrderViewModel
    {
        private OrderModel _selectedOrder;

        public OrderModel SelectedOrder
        {
            get => _selectedOrder;
            set => _selectedOrder = value;
        }

        public double OrderCost => SelectedOrder.Cost;

        public IEnumerable<IMeal> OrderedMeals => SelectedOrder.Meals;
        //public IEnumerable<IMeal> AvailableMeals => ;
    }
}
