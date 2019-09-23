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
        private ObservableCollection<IMeal> _meals;

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

        public ObservableCollection<IMeal> Meals
        {
            get => _meals;
            protected set
            {
                if (_meals == null)
                {
                    _meals = new ObservableCollection<IMeal>();
                }

                if (_meals != value)
                {
                    _meals = value;
                }
            }
        }

        public void AddMeal(IMeal meal)
        {
            Meals.Add(meal);
            Cost += meal.Cost;
        }

        public void RemoveMeal(IMeal meal)
        {
            Meals.Remove(meal);
            Cost -= meal.Cost;
        }
    }
}
