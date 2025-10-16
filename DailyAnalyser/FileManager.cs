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
        // This function will eventually return a list of categories from I/O but for now it uses InitCategories()
        public static List<ICategory> LoadCategories(User user)
        {
            return InitCategories();
        }
        
        // Creates categories for testing
        public static List<ICategory> InitCategories()
        {
            // IMPORTANT: You must add a definition like below for UI elements to feed it into the category constructor
            var trackBar = new TrackBar // notice trackBar instead of TrackBar
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
                new Category<double>("How much water have you drank today (L)", new ArrayList(){0, 50}, trackBar), // trackBar used here, not TrackBar
                new Category<int>("Overall mood (1-10)", new ArrayList(){1, 10}, numericUpDown),
                new Category<string>("Energy (Low / Medium / High)", new ArrayList() { "Low", "Medium", "High" }, comboBox) // Combobox will always have string bounds
            };

            return categories;
        }

        public static List<ICategory> InitCategories2()
        {
            // IMPORTANT: You must add a definition like below for UI elements to feed it into the category constructor
            var trackBar = new TrackBar // notice trackBar instead of TrackBar
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
                new Category<double>("How much sleep did you get today (hrs)", new ArrayList(){0, 120}, trackBar), // trackBar used here, not TrackBar
                new Category<int>("How tired were you today (1-5)", new ArrayList(){1, 5}, numericUpDown),
                new Category<string>("Sleep Quality (Poor / Mediocre / Good / Fantastic)", new ArrayList() { "Poor", "Mediocre", "Good", "Fantastic" }, comboBox) // Combobox will always have string bounds
            };

            return categories;
        }
    }
}
