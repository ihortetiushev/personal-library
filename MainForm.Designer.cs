namespace PersonalLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.allLiteratureTab = new System.Windows.Forms.TabPage();
            this.literatureSplitContainer = new System.Windows.Forms.SplitContainer();
            this.literatureGridView = new System.Windows.Forms.DataGridView();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.cateroriesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addNewCaterogyButton = new System.Windows.Forms.Button();
            this.cateroriesGridView = new System.Windows.Forms.DataGridView();
            this.authorsTab = new System.Windows.Forms.TabPage();
            this.authorsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addNewAuthorButton = new System.Windows.Forms.Button();
            this.authorsGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editViewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategotyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.allLiteratureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literatureSplitContainer)).BeginInit();
            this.literatureSplitContainer.Panel2.SuspendLayout();
            this.literatureSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literatureGridView)).BeginInit();
            this.categoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesSplitContainer)).BeginInit();
            this.cateroriesSplitContainer.Panel1.SuspendLayout();
            this.cateroriesSplitContainer.Panel2.SuspendLayout();
            this.cateroriesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesGridView)).BeginInit();
            this.authorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsSplitContainer)).BeginInit();
            this.authorsSplitContainer.Panel1.SuspendLayout();
            this.authorsSplitContainer.Panel2.SuspendLayout();
            this.authorsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.allLiteratureTab);
            this.tabControl.Controls.Add(this.categoriesTab);
            this.tabControl.Controls.Add(this.authorsTab);
            this.tabControl.Location = new System.Drawing.Point(12, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(903, 495);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // allLiteratureTab
            // 
            this.allLiteratureTab.Controls.Add(this.literatureSplitContainer);
            this.allLiteratureTab.Location = new System.Drawing.Point(4, 25);
            this.allLiteratureTab.Name = "allLiteratureTab";
            this.allLiteratureTab.Padding = new System.Windows.Forms.Padding(3);
            this.allLiteratureTab.Size = new System.Drawing.Size(895, 466);
            this.allLiteratureTab.TabIndex = 0;
            this.allLiteratureTab.Text = "Literature";
            this.allLiteratureTab.UseVisualStyleBackColor = true;
            // 
            // literatureSplitContainer
            // 
            this.literatureSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.literatureSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.literatureSplitContainer.Name = "literatureSplitContainer";
            this.literatureSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // literatureSplitContainer.Panel2
            // 
            this.literatureSplitContainer.Panel2.Controls.Add(this.literatureGridView);
            this.literatureSplitContainer.Size = new System.Drawing.Size(889, 460);
            this.literatureSplitContainer.SplitterDistance = 143;
            this.literatureSplitContainer.TabIndex = 0;
            // 
            // literatureGridView
            // 
            this.literatureGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.literatureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.literatureGridView.Location = new System.Drawing.Point(3, 3);
            this.literatureGridView.Name = "literatureGridView";
            this.literatureGridView.RowHeadersWidth = 51;
            this.literatureGridView.RowTemplate.Height = 24;
            this.literatureGridView.Size = new System.Drawing.Size(889, 307);
            this.literatureGridView.TabIndex = 0;
            // 
            // categoriesTab
            // 
            this.categoriesTab.Controls.Add(this.cateroriesSplitContainer);
            this.categoriesTab.Location = new System.Drawing.Point(4, 25);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTab.Size = new System.Drawing.Size(895, 466);
            this.categoriesTab.TabIndex = 1;
            this.categoriesTab.Text = "Categories";
            this.categoriesTab.UseVisualStyleBackColor = true;
            // 
            // cateroriesSplitContainer
            // 
            this.cateroriesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cateroriesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.cateroriesSplitContainer.Name = "cateroriesSplitContainer";
            this.cateroriesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cateroriesSplitContainer.Panel1
            // 
            this.cateroriesSplitContainer.Panel1.Controls.Add(this.addNewCaterogyButton);
            // 
            // cateroriesSplitContainer.Panel2
            // 
            this.cateroriesSplitContainer.Panel2.Controls.Add(this.cateroriesGridView);
            this.cateroriesSplitContainer.Size = new System.Drawing.Size(889, 460);
            this.cateroriesSplitContainer.SplitterDistance = 143;
            this.cateroriesSplitContainer.TabIndex = 0;
            // 
            // addNewCaterogyButton
            // 
            this.addNewCaterogyButton.Location = new System.Drawing.Point(710, 20);
            this.addNewCaterogyButton.Name = "addNewCaterogyButton";
            this.addNewCaterogyButton.Size = new System.Drawing.Size(150, 30);
            this.addNewCaterogyButton.TabIndex = 0;
            this.addNewCaterogyButton.Text = "Add New Category";
            this.addNewCaterogyButton.UseVisualStyleBackColor = true;
            this.addNewCaterogyButton.Click += new System.EventHandler(this.AddNewCaterogyButton_Click);
            // 
            // cateroriesGridView
            // 
            this.cateroriesGridView.AllowUserToAddRows = false;
            this.cateroriesGridView.AllowUserToDeleteRows = false;
            this.cateroriesGridView.AllowUserToResizeColumns = false;
            this.cateroriesGridView.AllowUserToResizeRows = false;
            this.cateroriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cateroriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cateroriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cateroriesGridView.Location = new System.Drawing.Point(0, 0);
            this.cateroriesGridView.MultiSelect = false;
            this.cateroriesGridView.Name = "cateroriesGridView";
            this.cateroriesGridView.ReadOnly = true;
            this.cateroriesGridView.RowHeadersWidth = 51;
            this.cateroriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cateroriesGridView.RowTemplate.Height = 24;
            this.cateroriesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cateroriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cateroriesGridView.Size = new System.Drawing.Size(889, 313);
            this.cateroriesGridView.TabIndex = 0;
            // 
            // authorsTab
            // 
            this.authorsTab.Controls.Add(this.authorsSplitContainer);
            this.authorsTab.Location = new System.Drawing.Point(4, 25);
            this.authorsTab.Name = "authorsTab";
            this.authorsTab.Size = new System.Drawing.Size(895, 466);
            this.authorsTab.TabIndex = 2;
            this.authorsTab.Text = "Authors";
            this.authorsTab.UseVisualStyleBackColor = true;
            // 
            // authorsSplitContainer
            // 
            this.authorsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.authorsSplitContainer.Name = "authorsSplitContainer";
            this.authorsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // authorsSplitContainer.Panel1
            // 
            this.authorsSplitContainer.Panel1.Controls.Add(this.addNewAuthorButton);
            // 
            // authorsSplitContainer.Panel2
            // 
            this.authorsSplitContainer.Panel2.Controls.Add(this.authorsGridView);
            this.authorsSplitContainer.Size = new System.Drawing.Size(895, 466);
            this.authorsSplitContainer.SplitterDistance = 143;
            this.authorsSplitContainer.TabIndex = 0;
            // 
            // addNewAuthorButton
            // 
            this.addNewAuthorButton.Location = new System.Drawing.Point(710, 20);
            this.addNewAuthorButton.Name = "addNewAuthorButton";
            this.addNewAuthorButton.Size = new System.Drawing.Size(150, 30);
            this.addNewAuthorButton.TabIndex = 0;
            this.addNewAuthorButton.Text = "Add New Author";
            this.addNewAuthorButton.UseVisualStyleBackColor = true;
            this.addNewAuthorButton.Click += new System.EventHandler(this.AddNewAuthorButton_Click);
            // 
            // authorsGridView
            // 
            this.authorsGridView.AllowUserToAddRows = false;
            this.authorsGridView.AllowUserToDeleteRows = false;
            this.authorsGridView.AllowUserToResizeColumns = false;
            this.authorsGridView.AllowUserToResizeRows = false;
            this.authorsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.authorsGridView.ColumnHeadersHeight = 29;
            this.authorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.authorsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsGridView.Location = new System.Drawing.Point(0, 0);
            this.authorsGridView.MultiSelect = false;
            this.authorsGridView.Name = "authorsGridView";
            this.authorsGridView.ReadOnly = true;
            this.authorsGridView.RowHeadersWidth = 51;
            this.authorsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.authorsGridView.RowTemplate.Height = 24;
            this.authorsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.authorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorsGridView.Size = new System.Drawing.Size(895, 319);
            this.authorsGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.libraryToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem1.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.editViewCategoryToolStripMenuItem,
            this.deleteCategotyToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.AddNewCategoryToolStripMenuItem_Click);
            // 
            // editViewToolStripMenuItem
            // 
            this.editViewCategoryToolStripMenuItem.Name = "editViewCategoryToolStripMenuItem";
            this.editViewCategoryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editViewCategoryToolStripMenuItem.Text = "View/Edit Category";
            this.editViewCategoryToolStripMenuItem.Click += new System.EventHandler(this.EditViewToolStripMenuItem_Click);
            // 
            // deleteCategotyToolStripMenuItem
            // 
            this.deleteCategotyToolStripMenuItem.Name = "deleteCategotyToolStripMenuItem";
            this.deleteCategotyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteCategotyToolStripMenuItem.Text = "Delete Categoty";
            this.deleteCategotyToolStripMenuItem.Click += new System.EventHandler(this.DeleteCategotyToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAutorToolStripMenuItem,
            this.editAuthorToolStripMenuItem,
            this.deleteAuthorToolStripMenuItem});
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // addNewAutorToolStripMenuItem
            // 
            this.addNewAutorToolStripMenuItem.Name = "addNewAutorToolStripMenuItem";
            this.addNewAutorToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.addNewAutorToolStripMenuItem.Text = "Add New Autor";
            this.addNewAutorToolStripMenuItem.Click += new System.EventHandler(this.AddNewAutorToolStripMenuItem_Click);
            // 
            // editAuthorToolStripMenuItem
            // 
            this.editAuthorToolStripMenuItem.Name = "editAuthorToolStripMenuItem";
            this.editAuthorToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.editAuthorToolStripMenuItem.Text = "View/Edit Author";
            this.editAuthorToolStripMenuItem.Click += new System.EventHandler(this.EditAuthorToolStripMenuItem_Click);
            // 
            // deleteAuthorToolStripMenuItem
            // 
            this.deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            this.deleteAuthorToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.deleteAuthorToolStripMenuItem.Text = "Delete Author";
            this.deleteAuthorToolStripMenuItem.Click += new System.EventHandler(this.DeleteAuthorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 539);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.allLiteratureTab.ResumeLayout(false);
            this.literatureSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.literatureSplitContainer)).EndInit();
            this.literatureSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.literatureGridView)).EndInit();
            this.categoriesTab.ResumeLayout(false);
            this.cateroriesSplitContainer.Panel1.ResumeLayout(false);
            this.cateroriesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesSplitContainer)).EndInit();
            this.cateroriesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesGridView)).EndInit();
            this.authorsTab.ResumeLayout(false);
            this.authorsSplitContainer.Panel1.ResumeLayout(false);
            this.authorsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsSplitContainer)).EndInit();
            this.authorsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allLiteratureTab;
        private System.Windows.Forms.TabPage categoriesTab;
        private System.Windows.Forms.SplitContainer literatureSplitContainer;
        private System.Windows.Forms.DataGridView literatureGridView;
        private System.Windows.Forms.TabPage authorsTab;
        private System.Windows.Forms.SplitContainer authorsSplitContainer;
        private System.Windows.Forms.DataGridView authorsGridView;
        private System.Windows.Forms.SplitContainer cateroriesSplitContainer;
        private System.Windows.Forms.DataGridView cateroriesGridView;
        private System.Windows.Forms.Button addNewAuthorButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addNewCaterogyButton;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editViewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategotyToolStripMenuItem;
    }
}