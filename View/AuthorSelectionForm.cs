using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static PersonalLibrary.View.UIHelper;

namespace PersonalLibrary.View
{
    public partial class AuthorSelectionForm : ReferenceSelectionForm<Author>
    {
        public AuthorSelectionForm(Repository repository, UIState uiState):base(repository, uiState) 
        {
            Initialize();

        }
        private void Initialize() 
        {
            this.Text = "Selecct Author And Press Ok Button";
        }
        protected override List<Author> LoadData() 
        {
            return this.repository.GetAuthorDao().GetAllAuthors();
        }

        protected override DataTable CreateDataTable(DataGridView gridView) 
        {
            return CreateAuthorTable(gridView);
        }

        protected override object[] ToDataRow(Author data) 
        {
            return ToAuthorRow(data);
        }

        protected override Author loadSelectItem(int itemId)
        {
           return this.repository.GetAuthorDao().GetById(itemId);
        }
    }
}
