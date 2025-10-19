using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;

namespace DailyAnalyser
{
    public static class ExcelManager
    {
        private static string GetFilePath(User user)
            => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{user.name}.xlsx");

        public static void SaveUserAnswers(User user, string notes)
        {
            string filePath = GetFilePath(user);
            var date = DateTime.Now.ToString("yyyy-MM-dd");

            var wb = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook();
            var ws = wb.Worksheets.FirstOrDefault() ?? wb.AddWorksheet("Daily Data");

            if (ws.Cell(1,1).IsEmpty())
            {
                ws.Cell(1, 1).Value = "Date";
                int i = 0;
                for (i = 0; i < user.categories.Count; i++)
                    ws.Cell(1, i + 2).Value = user.categories[i].Question;
                ws.Cell(1, i + 2).Value = "Notes";
            }

            int nextRow = 2;
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
