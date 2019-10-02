using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using OrderSoftware9000.Models;

namespace OrderSoftware9000.ViewModel
{
    public class MealsVM : ObservableObject
    {
        private MealM[] _meals;

        public MealsVM()
        {
            object o = Application.Current.FindResource("meals");
            _meals = (MealM[])o;
        }

        public IEnumerable<MealM> Meals => _meals;
    }
}
