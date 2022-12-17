using PersonalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary.View
{
    public class UIHelper
    {
        public static readonly int ID_COLUMN_INDEX = 0;
        public static readonly int CATEGORY_COLUMN_INDEX_NAME = 1;
        public static readonly int CATEGORY_COLUMN_INDEX_DESC = 2;
        private UIHelper() 
        {
        }
        public static bool HasSelectedRow(DataGridView grid)
        {
            DataGridViewSelectedRowCollection selected = grid.SelectedRows;
            if (selected.Count == 0)
            {
                MessageBox.Show("No data selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static DataTable CreateCategotyTable(DataGridView gridView)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Id", Type.GetType("System.Int32")));
            table.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("Description", Type.GetType("System.String")));

            gridView.DataSource = table;
            gridView.Columns[ID_COLUMN_INDEX].Width = 50;
            gridView.Columns[CATEGORY_COLUMN_INDEX_NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridView.Columns[CATEGORY_COLUMN_INDEX_DESC].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return table;
        }

        public static DataTable PopulateCategoryGridData(List<Category> categories, DataGridView gridView)
        {
            DataTable table = CreateCategotyTable(gridView);
            foreach (Category category in categories)
            {
                table.LoadDataRow(ToCategoryRow(category), true);
            }
            return table;
        }

        public static object[] ToCategoryRow(Category category)
        {
            object[] values = new object[3];
            values[ID_COLUMN_INDEX] = category.CategoryId;
            values[CATEGORY_COLUMN_INDEX_NAME] = category.Name;
            values[CATEGORY_COLUMN_INDEX_DESC] = category.Description;
            return values;
        }
    }
}
