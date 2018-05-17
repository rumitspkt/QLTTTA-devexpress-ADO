using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTTA.Utils
{
   static class ExportFileExcel
   {
      public static void export2FileExcel(DevExpress.XtraGrid.Views.Grid.GridView g, string fileLocation)
      {
         Microsoft.Office.Interop.Excel.Application obj = new Microsoft.Office.Interop.Excel.Application();
         obj.Application.Workbooks.Add(Type.Missing);
         obj.Columns.ColumnWidth = 20;
         for (int i = 1; i < g.Columns.Count + 1; i++)
         {
            obj.Cells[1, i] = g.Columns[i - 1].Caption;
         }
         for (int i = 0; i < g.DataRowCount; i++)
         {
            for (int j = 0; j < g.Columns.Count; j++)
            {
               obj.Cells[i + 2, j + 1] = g.GetRowCellValue(i, g.Columns[j]).ToString();
            }
         }
         obj.ActiveWorkbook.SaveCopyAs(fileLocation);
         obj.ActiveWorkbook.Saved = true;
      }
   }
}
