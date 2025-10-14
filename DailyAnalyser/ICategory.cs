using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    public interface ICategory // Interface for Category
    {
        string Question { get; }
        // Using an interface means we can have a list of Category<T> without <T> being the same
        object Answer { get; set; } 
        System.Windows.Forms.Control Type { get; }
        ArrayList Bounds { get; } 
    }
}
