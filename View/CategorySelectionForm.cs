using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static PersonalLibrary.View.UIHelper;

namespace PersonalLibrary.View
{
    public partial class CategorySelectionForm : ReferenceSelectionForm<Category>
    {
        public CategorySelectionForm(Repository repository, UIState uiState):base(repository, uiState) 
        {
        }
        protected override List<Category> LoadData() 
        {
            return this.repository.GetCategoryDao().GetAllCategories();
        }

        protected override DataTable CreateDataTable(DataGridView gridView) 
        {
            return CreateCategoryTable(gridView);
        }

        protected override object[] ToDataRow(Category data) 
        {
            return ToCategoryRow(data);
        }

        protected override Category loadSelectItem(int itemId)
        {
           return this.repository.GetCategoryDao().GetById(itemId);
        }
    }
}
