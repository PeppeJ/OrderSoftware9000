using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using OrderSoftware9000.Models;

namespace OrderSoftware9000.ViewModel
{
    public class MealsViewModel : ObservableObject
    {
        private MealModel[] _meals;

        public MealsViewModel()
        {
            object o = Application.Current.FindResource("meals");
            _meals = (MealModel[])o;
        }

        public IEnumerable<MealModel> Meals => _meals;
    }
}
