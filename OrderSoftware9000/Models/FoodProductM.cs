using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.Models
{
    public class FoodProductM : ObservableObject, IProduct, INutrients
    {
        private string _name;
        private double _cost;

        private int _weight;

        private ObservableCollection<IngredientM> _ingredients;

        public ICollection<IngredientM> Ingredients { get => _ingredients; }

        private double _carbohydrates;

        public double Carbohydrates
        {
            get => _carbohydrates;
            set
            {
                if (_carbohydrates != value)
                {
                    _carbohydrates = value;
                    OnPropertyChanged(nameof(Carbohydrates));
                }
            }
        }

        private double _fat;

        public double Fat
        {
            get => _fat;
            set
            {
                if (_fat != value)
                {
                    _fat = value;
                    OnPropertyChanged(nameof(Fat));
                }
            }
        }

        private int _kcal;

        public int Kcal
        {
            get => _kcal;
            set
            {
                if (_kcal != value)
                {
                    _kcal = value;
                    OnPropertyChanged(nameof(Kcal));
                }
            }
        }

        private double _protein;

        public double Protein
        {
            get => _protein;
            set
            {
                if (_protein != value)
                {
                    _protein = value;
                    OnPropertyChanged(nameof(Protein));
                }
            }
        }

        public FoodProductM()
        {
            PropertyChanged += FoodProductM_IngredientsChanged;
        }

        private void FoodProductM_IngredientsChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_ingredients))
            {
                //TODO finish up.
                double[] carbsArr = Ingredients.Select(x => x.Carbohydrates).ToArray();
            }
        }

        public FoodProductM(string name, int weight, double cost)
            : this()
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }

        public FoodProductM(string name, int weight, double cost, IEnumerable<IngredientM> ingredients)
            : this(name, weight, cost)
        {
            _ingredients = new ObservableCollection<IngredientM>(ingredients);
        }

        public int Weight
        {
            get => _weight;
            set
            {
                if (_weight != value)
                {
                    _weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
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

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


    }
}
