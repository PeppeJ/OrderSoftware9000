using System.Collections.Generic;
using System.Collections.ObjectModel;

using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.Models
{
    public class MealM : ObservableObject, IProduct
    {
        private double _cost;
        private ObservableCollection<FoodProductM> _foods;
        private string _name;
        private int _weight;

        public ICollection<IngredientM> Ingredients { get; }

        public int Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        public MealM() { }

        public MealM(string name, double cost, IEnumerable<FoodProductM> ingredients)
        {
            Name = name;
            Cost = cost;
            Food = new ObservableCollection<FoodProductM>(ingredients);
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

        public ObservableCollection<FoodProductM> Food
        {
            get => _foods;
            private set => _foods = value;
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