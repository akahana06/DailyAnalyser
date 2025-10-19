using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;
using System.Collections;

namespace DailyAnalyser
{
    public static class ExcelManager
    {
        private static string GetFilePath(User user)
            => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{user.id}.xlsx");

        public static List<ICategory> LoadCategories(User user)
        {
            List<ICategory> categories = new List<ICategory>();
            string filePath = GetFilePath(user);

            if (!File.Exists(filePath)) return null;

            var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheets.FirstOrDefault();
            
            int i = 1;
            while(!ws.Cell(1, i).IsEmpty())
            {
                System.Windows.Forms.Control qType;

                ArrayList bounds = new ArrayList(ws.Cell(2, i).GetText().Split(','));
                string graphType = ws.Cell(3, i).GetText();
                string question = ws.Cell(4, i).GetText();

                if (ws.Cell(1, i).GetText() == "TrackBar")
                {
                    qType = new TrackBar { TickStyle = TickStyle.None, Width = 200 };
                    categories.Add(new Category<double>(question, bounds, qType, graphType));
                } else if (ws.Cell(1,i).GetText() == "NumericUpDown")
                {
                    qType = new NumericUpDown { };
                    categories.Add(new Category<int>(question, bounds, qType, graphType));
                } else if (ws.Cell(1,i).GetText() == "ComboBox")
                {
                    qType = new ComboBox { };
                    categories.Add(new Category<string>(question, bounds, qType, graphType));
                }
                i++;
            }
            return categories;

        }
        
        public static void SaveUserAnswers(User user, string notes)
        {
            string filePath = GetFilePath(user);
            var date = DateTime.Now.ToString("yyyy-MM-dd");

            var wb = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook();
            var ws = wb.Worksheets.FirstOrDefault() ?? wb.AddWorksheet("Daily Data");

            if (ws.Cell(1,1).IsEmpty())
            {
                ws.Cell(1, 1).Value = "Type";
                ws.Cell(2, 1).Value = "Bounds";
                ws.Cell(3, 1).Value = "Graph Type";
                ws.Cell(4, 1).Value = "Date";
                int i = 0;
                for (i = 0; i < user.categories.Count; i++)
                {
                    ws.Cell(1, i + 2).Value = user.categories[i].Type.GetType().Name;
                    ws.Cell(2, i + 2).Value = string.Join(",", user.categories[i].Bounds.Cast<object>());
                    ws.Cell(3, i + 2).Value = user.categories[i].GraphType;
                    ws.Cell(4, i + 2).Value = user.categories[i].Question;
                }
                ws.Cell(4, i + 2).Value = "Notes";
            }

            int nextRow = 5;
            while (!ws.Cell(nextRow, 1).IsEmpty())
            {
                nextRow++;
            }
            
            if (ws.Cell(nextRow - 1, 1).Value.ToString() == date)
            {
                DialogResult result = MessageBox.Show("Entry already completed today, overwrite?", "Overwrite Entry", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    nextRow--;
                }
                else
                {
                    return;
                }

            }
            ws.Cell(nextRow, 1).Value = date;

            for (int i = 0; i < user.categories.Count; i++)
            {
                var answer = user.categories[i].Answer?.ToString() ?? "";
                ws.Cell(nextRow, i + 2).Value = answer;
            }

            ws.Cell(nextRow, user.categories.Count + 2).Value = notes;

            if (File.Exists(filePath))
                wb.Save();
            else
                wb.SaveAs(filePath);
        }
    }

}
