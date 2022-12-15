using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary.View
{
    public partial class AddEditLiteratureForm : Form
    {
        private readonly Repository repository;
        private readonly UIState uiState;
        private readonly bool readOnly;
        private readonly bool editMode;
        private readonly Literature toEdit;
        public AddEditLiteratureForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            this.repository = repository;
            this.uiState = uiState;
            this.readOnly = this.uiState.LoggedInUser.Type == User.UserType.Reader;
            this.toEdit = (Literature)this.uiState.LastModified;
            this.editMode = toEdit != null;
            //PopulateEditingData();
        }

    }
}
