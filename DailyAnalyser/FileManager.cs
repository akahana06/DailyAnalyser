using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    static class FileManager
    {
        public static List<ICategory> LoadCategories(User user)
        {
            return InitCategories();
        }

        public static List<ICategory> InitCategories()
        {
            var trackBar = new TrackBar
            {
                TickStyle = TickStyle.None,
                Width = 200
            };

            var numericUpDown = new NumericUpDown
            {

            };

            var radioButton = new RadioButton
            {

            };

            var comboBox = new ComboBox
            {

            };
            
            List<ICategory> categories = new List<ICategory>
            {
                new Category<double>("How much water have you drank today (L)", new ArrayList(){0, 5000}, trackBar),
                new Category<int>("Overall mood (1-10)", new ArrayList(){1, 10}, numericUpDown),
                new Category<string>("Energy (Low / Medium / High)", new ArrayList() { "Low", "Medium", "High" }, comboBox)
            };

            return categories;
        }
    }
}
