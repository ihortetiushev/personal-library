namespace PersonalLibrary.View
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
            this.availabilityCheckbox = new System.Windows.Forms.CheckBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.literatureGridView = new System.Windows.Forms.DataGridView();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.categoriesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addNewCategoryButton = new System.Windows.Forms.Button();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.authorsTab = new System.Windows.Forms.TabPage();
            this.authorsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addNewAuthorButton = new System.Windows.Forms.Button();
            this.authorsGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLiteratureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditLiteratureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLiteratureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.literatureSplitContainer.Panel1.SuspendLayout();
            this.literatureSplitContainer.Panel2.SuspendLayout();
            this.literatureSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literatureGridView)).BeginInit();
            this.categoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesSplitContainer)).BeginInit();
            this.categoriesSplitContainer.Panel1.SuspendLayout();
            this.categoriesSplitContainer.Panel2.SuspendLayout();
            this.categoriesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
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
            // literatureSplitContainer.Panel1
            // 
            this.literatureSplitContainer.Panel1.Controls.Add(this.availabilityCheckbox);
            this.literatureSplitContainer.Panel1.Controls.Add(this.searchLabel);
            this.literatureSplitContainer.Panel1.Controls.Add(this.titleInput);
            this.literatureSplitContainer.Panel1.Controls.Add(this.titleLabel);
            this.literatureSplitContainer.Panel1.Controls.Add(this.lastNameLabel);
            this.literatureSplitContainer.Panel1.Controls.Add(this.lastNameInput);
            this.literatureSplitContainer.Panel1.Controls.Add(this.firstNameInput);
            this.literatureSplitContainer.Panel1.Controls.Add(this.firstNameLabel);
            this.literatureSplitContainer.Panel1.Controls.Add(this.searchButton);
            this.literatureSplitContainer.Panel1.Controls.Add(this.clearButton);
            // 
            // literatureSplitContainer.Panel2
            // 
            this.literatureSplitContainer.Panel2.Controls.Add(this.literatureGridView);
            this.literatureSplitContainer.Size = new System.Drawing.Size(889, 460);
            this.literatureSplitContainer.SplitterDistance = 166;
            this.literatureSplitContainer.TabIndex = 0;
            // 
            // availabilityCheckbox
            // 
            this.availabilityCheckbox.AutoSize = true;
            this.availabilityCheckbox.Checked = true;
            this.availabilityCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.availabilityCheckbox.Location = new System.Drawing.Point(27, 147);
            this.availabilityCheckbox.Name = "availabilityCheckbox";
            this.availabilityCheckbox.Size = new System.Drawing.Size(99, 20);
            this.availabilityCheckbox.TabIndex = 21;
            this.availabilityCheckbox.Text = "Is Available";
            this.availabilityCheckbox.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(24, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(90, 16);
            this.searchLabel.TabIndex = 20;
            this.searchLabel.Text = "Search Fields";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(143, 97);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(623, 22);
            this.titleInput.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(24, 103);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Title";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(398, 58);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(113, 16);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Author Last Name";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(526, 52);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(240, 22);
            this.lastNameInput.TabIndex = 16;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(143, 52);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(240, 22);
            this.firstNameInput.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(24, 58);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 16);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "Author First Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(773, 92);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 32);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(773, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 32);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // literatureGridView
            // 
            this.literatureGridView.AllowUserToAddRows = false;
            this.literatureGridView.AllowUserToDeleteRows = false;
            this.literatureGridView.AllowUserToResizeColumns = false;
            this.literatureGridView.AllowUserToResizeRows = false;
            this.literatureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.literatureGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.literatureGridView.Location = new System.Drawing.Point(0, 0);
            this.literatureGridView.Name = "literatureGridView";
            this.literatureGridView.ReadOnly = true;
            this.literatureGridView.RowHeadersVisible = false;
            this.literatureGridView.RowHeadersWidth = 51;
            this.literatureGridView.RowTemplate.Height = 24;
            this.literatureGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.literatureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.literatureGridView.Size = new System.Drawing.Size(889, 290);
            this.literatureGridView.TabIndex = 0;
            // 
            // categoriesTab
            // 
            this.categoriesTab.Controls.Add(this.categoriesSplitContainer);
            this.categoriesTab.Location = new System.Drawing.Point(4, 25);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTab.Size = new System.Drawing.Size(895, 466);
            this.categoriesTab.TabIndex = 1;
            this.categoriesTab.Text = "Categories";
            this.categoriesTab.UseVisualStyleBackColor = true;
            // 
            // categoriesSplitContainer
            // 
            this.categoriesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.categoriesSplitContainer.Name = "categoriesSplitContainer";
            this.categoriesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // categoriesSplitContainer.Panel1
            // 
            this.categoriesSplitContainer.Panel1.Controls.Add(this.addNewCategoryButton);
            // 
            // categoriesSplitContainer.Panel2
            // 
            this.categoriesSplitContainer.Panel2.Controls.Add(this.categoriesGridView);
            this.categoriesSplitContainer.Size = new System.Drawing.Size(889, 460);
            this.categoriesSplitContainer.SplitterDistance = 143;
            this.categoriesSplitContainer.TabIndex = 0;
            // 
            // addNewCategoryButton
            // 
            this.addNewCategoryButton.Location = new System.Drawing.Point(710, 20);
            this.addNewCategoryButton.Name = "addNewCategoryButton";
            this.addNewCategoryButton.Size = new System.Drawing.Size(150, 30);
            this.addNewCategoryButton.TabIndex = 0;
            this.addNewCategoryButton.Text = "Add New Category";
            this.addNewCategoryButton.UseVisualStyleBackColor = true;
            this.addNewCategoryButton.Click += new System.EventHandler(this.AddNewCategoryButton_Click);
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AllowUserToAddRows = false;
            this.categoriesGridView.AllowUserToDeleteRows = false;
            this.categoriesGridView.AllowUserToResizeColumns = false;
            this.categoriesGridView.AllowUserToResizeRows = false;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.categoriesGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesGridView.MultiSelect = false;
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.ReadOnly = true;
            this.categoriesGridView.RowHeadersVisible = false;
            this.categoriesGridView.RowHeadersWidth = 51;
            this.categoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoriesGridView.RowTemplate.Height = 24;
            this.categoriesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categoriesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesGridView.Size = new System.Drawing.Size(889, 313);
            this.categoriesGridView.TabIndex = 0;
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
            this.authorsGridView.RowHeadersVisible = false;
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
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLiteratureToolStripMenuItem,
            this.viewEditLiteratureToolStripMenuItem,
            this.deleteLiteratureToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // addLiteratureToolStripMenuItem
            // 
            this.addLiteratureToolStripMenuItem.Name = "addLiteratureToolStripMenuItem";
            this.addLiteratureToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addLiteratureToolStripMenuItem.Text = "Add Literature";
            this.addLiteratureToolStripMenuItem.Click += new System.EventHandler(this.AddLiteratureToolStripMenuItem_Click);
            // 
            // viewEditLiteratureToolStripMenuItem
            // 
            this.viewEditLiteratureToolStripMenuItem.Name = "viewEditLiteratureToolStripMenuItem";
            this.viewEditLiteratureToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.viewEditLiteratureToolStripMenuItem.Text = "View/Edit Literature";
            this.viewEditLiteratureToolStripMenuItem.Click += new System.EventHandler(this.ViewEditLiteratureToolStripMenuItem_Click);
            // 
            // deleteLiteratureToolStripMenuItem
            // 
            this.deleteLiteratureToolStripMenuItem.Name = "deleteLiteratureToolStripMenuItem";
            this.deleteLiteratureToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.deleteLiteratureToolStripMenuItem.Text = "Delete Literature";
            this.deleteLiteratureToolStripMenuItem.Click += new System.EventHandler(this.DeleteLiteratureToolStripMenuItem_Click);
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
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addNewCategoryToolStripMenuItem.Text = "Add Category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.AddNewCategoryToolStripMenuItem_Click);
            // 
            // editViewCategoryToolStripMenuItem
            // 
            this.editViewCategoryToolStripMenuItem.Name = "editViewCategoryToolStripMenuItem";
            this.editViewCategoryToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.editViewCategoryToolStripMenuItem.Text = "View/Edit Category";
            this.editViewCategoryToolStripMenuItem.Click += new System.EventHandler(this.ViewEditCategoryToolStripMenuItem_Click);
            // 
            // deleteCategotyToolStripMenuItem
            // 
            this.deleteCategotyToolStripMenuItem.Name = "deleteCategotyToolStripMenuItem";
            this.deleteCategotyToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
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
            this.addNewAutorToolStripMenuItem.Text = "Add Autor";
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
            this.literatureSplitContainer.Panel1.ResumeLayout(false);
            this.literatureSplitContainer.Panel1.PerformLayout();
            this.literatureSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.literatureSplitContainer)).EndInit();
            this.literatureSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.literatureGridView)).EndInit();
            this.categoriesTab.ResumeLayout(false);
            this.categoriesSplitContainer.Panel1.ResumeLayout(false);
            this.categoriesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesSplitContainer)).EndInit();
            this.categoriesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
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
        private System.Windows.Forms.SplitContainer categoriesSplitContainer;
        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.Button addNewAuthorButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addNewCategoryButton;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editViewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategotyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLiteratureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditLiteratureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLiteratureToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox availabilityCheckbox;
    }
}