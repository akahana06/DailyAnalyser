using ClosedXML.Excel;
using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    public static class ExcelManager
    {
        private static string GetFilePath(User user, bool init)
            => init ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{user.id}init.xlsx") 
            : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{user.id}.xlsx");

        public static List<ICategory> LoadCategories(User user, bool init)
        {
            List<ICategory> categories = new List<ICategory>();
            string filePath = GetFilePath(user, init);

            if (!File.Exists(filePath)) filePath = GetFilePath(user, true);

            var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheets.FirstOrDefault();
            
            int i = 2;
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

            wb.Dispose();
            return categories;

        }

        public static void InitialiseDb(User user)
        {
            string filePath = GetFilePath(user, false);
            string initFilePath = GetFilePath(user, true);

            if (!File.Exists(filePath))
            {
                if (File.Exists(initFilePath))
                {
                    File.Copy(initFilePath, filePath);
                }
                else
                {
                    var tempWb = new XLWorkbook();
                    tempWb.AddWorksheet("Daily Data");
                    tempWb.SaveAs(filePath);
                    tempWb.Dispose();
                }
            }
        }
        
        public static void SaveUserAnswers(User user, string notes)
        {
            string filePath = GetFilePath(user, false);

            var date = DateTime.Now.ToString("yyyy-MM-dd");
            var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheets.FirstOrDefault();

            if (ws.Cell(1,2).IsEmpty())
            {
                ws.Cell(1, 2).Value = "Type";
                ws.Cell(2, 2).Value = "Bounds";
                ws.Cell(3, 2).Value = "Graph Type";
                ws.Cell(4, 2).Value = "Date";
                int i = 0;
                for (i = 0; i < user.categories.Count; i++)
                {
                    ws.Cell(1, i + 3).Value = user.categories[i].Type.GetType().Name;
                    ws.Cell(2, i + 3).Value = string.Join(",", user.categories[i].Bounds.Cast<object>());
                    ws.Cell(3, i + 3).Value = user.categories[i].GraphType;
                    ws.Cell(4, i + 3).Value = user.categories[i].Question;
                }
                ws.Cell(4, 1).Value = "Notes";
            }

            int nextRow = 5;
            while (!ws.Cell(nextRow, 2).IsEmpty())
            {
                nextRow++;
            }
            
            if (ws.Cell(nextRow - 1, 2).Value.ToString() == date)
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
            
            ws.Cell(nextRow, 2).Value = date;
            for (int i = 0; i < user.categories.Count; i++)
            {
                var answer = user.categories[i].Answer?.ToString() ?? "";
                ws.Cell(nextRow, i + 3).Value = answer;
            }

            ws.Cell(nextRow, 1).Value = notes;

            wb.Save();
            wb.Dispose();
        }

        public static void AddQuestion(User user, ICategory category)
        {
            string filePath = GetFilePath(user, false);

            var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheets.FirstOrDefault();

            int nextCol = 3;
            while (!ws.Cell(4, nextCol).IsEmpty())
            {
                nextCol++;
            }

            ws.Cell(1, nextCol).Value = category.Type.GetType().Name;
            ws.Cell(2, nextCol).Value = string.Join(",", category.Bounds.Cast<object>());
            ws.Cell(3, nextCol).Value = category.GraphType;
            ws.Cell(4, nextCol).Value = category.Question;

            wb.Save();
            wb.Dispose();
        }

        public static void RemoveQuestion(User user, ICategory category)
        {
            string filePath = GetFilePath(user, false);

            var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheets.FirstOrDefault();

            int nextCol = 3;
            while (ws.Cell(4, nextCol).Value.ToString() != category.Question)
            {
                nextCol++;
            }

            ws.Column(nextCol).Delete();

            wb.Save();
            wb.Dispose();
        }
    }

}
