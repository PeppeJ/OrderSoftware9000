using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using OrderSoftware9000.Models;
using OrderSoftware9000.Models.Interfaces;
using System.Text.Json;

namespace OrderSoftware9000
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            IngredientM m = new IngredientM("Flour", 352, 72.40, 1.88, 8.47);
            List<IngredientM> ms = new List<IngredientM>();
            ms.Add(m);

            FoodProductM mp = new FoodProductM("Burger", 150, 10.00, new IngredientM[] { m });

            string s = JsonSerializer.Serialize(mp);
            Clipboard.SetText(s);
        }
    }
}
