using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.Models
{
    public class OrderModel : ObservableObject
    {
        private double _cost;
        private ObservableCollection<IProduct> _meals;

        public OrderModel()
        {

        }

        public double Cost
        {
            get => _cost;
            set
            {
                if (_cost != value)
                {
                    _cost = value;
                    OnPropertyChanged(nameof(Cost));
                }
            }
        }

        public ObservableCollection<IProduct> Meals
        {
            get => _meals;
            protected set
            {
                if (_meals == null)
                {
                    _meals = new ObservableCollection<IProduct>();
                }

                if (_meals != value)
                {
                    _meals = value;
                }
            }
        }

        public void AddMeal(IProduct meal)
        {
            Meals.Add(meal);
            Cost += meal.Cost;
        }

        public void RemoveMeal(IProduct meal)
        {
            Meals.Remove(meal);
            Cost -= meal.Cost;
        }
    }
}
