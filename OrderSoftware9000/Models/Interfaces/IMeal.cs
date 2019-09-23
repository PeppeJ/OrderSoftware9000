using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OrderSoftware9000.Models.Interfaces
{
    public interface IMeal
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public ObservableCollection<Ingredient> Ingredients { get; }
    }
}
