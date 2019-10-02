using System.ComponentModel;

using OrderSoftware9000.Models.Interfaces;
using System.Text.Json;

namespace OrderSoftware9000.Models
{
    public class IngredientM : ObservableObject, INutrients
    {
        private string _name;
        private double _carbohydrates;
        private double _fat;
        private int _kcal;
        private double _protein;

        public IngredientM()
        {

        }

        public IngredientM(string name, int kcal, double carbohydrates, double fat, double protein)
        {
            Name = name;
            Carbohydrates = carbohydrates;
            Fat = fat;
            Kcal = kcal;
            Protein = protein;
        }

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