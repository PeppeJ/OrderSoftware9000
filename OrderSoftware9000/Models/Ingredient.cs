using System.ComponentModel;

using OrderSoftware9000.Models.Interfaces;

namespace OrderSoftware9000.Models
{
    public class Ingredient : ObservableObject, INutrients
    {
        private double _carbohydrates;
        private double _fat;
        private int _kcal;
        private string _name;
        private double _protein;

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
    }
}