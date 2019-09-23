using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.Models
{
    public class MealModel : ObservableObject, IMeal
    {
        private double _cost;
        private ObservableCollection<Ingredient> _ingredients;
        private string _name;

        public MealModel()
        {
        }

        public MealModel(string name, double cost, IEnumerable<Ingredient> ingredients)
        {
            Name = name;
            Cost = cost;
            Ingredients = new ObservableCollection<Ingredient>(ingredients);
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

        public ObservableCollection<Ingredient> Ingredients
        {
            get => _ingredients;
            private set => _ingredients = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
    }
}
