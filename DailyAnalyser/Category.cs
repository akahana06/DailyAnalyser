using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAnalyser
{
    public class Category<T> : ICategory
    {
        public string Question { get; set; }
        public T Answer { get; set; }
        public ArrayList Bounds {  get; set; }
        public System.Windows.Forms.Control Type { get; set; }
        // TrackBar, CheckBox, ComboBox

        // public string type;

        object ICategory.Answer
        {
            get => Answer!;
            set => Answer = (T)value;
        }
        
        public Category(string question, ArrayList bounds, System.Windows.Forms.Control type) 
        { 
            this.Question = question;
            this.Bounds = bounds;
            this.Type = type;
        }

        public object GetAnswer() => Answer;
        
        public void SetAnswer(T answer) 
        { 
            this.Answer = answer;
        }

        public override string ToString() 
        {
            return $"{Answer}";
        }
    }

    public static class CategoryBounds
    {
        public static bool IsRange<T>(this Category<T> category)
        {
            return (category.Bounds[0] is string) ? false : true;
        }
    }
}
