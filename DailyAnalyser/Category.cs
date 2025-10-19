using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAnalyser
{
    public class Category<T> : ICategory // Inherits ICategory Interface
    {
        public string Question { get; set; }
        public T Answer { get; set; }
        // ArrayList used to define the bounds since it is generic. 
        // If <T> is int or double, Bounds will be formatted as { min, max }
        //              What was your mood today? { 0, 10 }
        // If <T> is a string (like for a ComboBox), Bounds will be a list of answers { Low, Medium, High }
        //              How was your energy today? { Low, Average, High }
        public ArrayList Bounds {  get; set; }
        public string GraphType { get; set;  }
        public System.Windows.Forms.Control Type { get; set; }
        // System.Windows.Forms.Control define UI elements like TrackBar, CheckBox, ComboBox etc.

        object ICategory.Answer // Defines ICategory getters and setters to be flexible with the generic nature of "Answer"
        {
            get => Answer!;
            set => Answer = (T)value;
        }
        //
        public Category(string question, ArrayList bounds, System.Windows.Forms.Control type) 
        { 
            this.Question = question;
            this.Bounds = bounds;
            this.Type = type;
            this.GraphType = "";
        }

        public Category(string question, ArrayList bounds, System.Windows.Forms.Control type, string graphType)
        {
            this.Question = question;
            this.Bounds = bounds;
            this.Type = type;
            this.GraphType = graphType;
        }

        public override string ToString() 
        {
            return Question;
        }
    }
    
}
