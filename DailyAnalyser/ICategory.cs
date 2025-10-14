using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    public interface ICategory
    {
        string Question { get; }
        object Answer { get; set; }
        System.Windows.Forms.Control Type { get; }
        ArrayList Bounds { get; }
    }
}
