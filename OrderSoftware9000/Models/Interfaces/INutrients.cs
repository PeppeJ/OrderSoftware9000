using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSoftware9000.Models.Interfaces
{
    public interface INutrients
    {
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public int Kcal { get; set; }
        public double Protein { get; set; }
    }
}
