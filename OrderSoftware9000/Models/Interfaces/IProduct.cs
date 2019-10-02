using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OrderSoftware9000.Models.Interfaces
{
    public interface IProduct
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Weight { get; set; }
        public ICollection<IngredientM> Ingredients { get; }
    }
}
