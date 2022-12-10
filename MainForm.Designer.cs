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
            this.cateroriesGridView = new System.Windows.Forms.DataGridView();
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.authorsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.authorsGridView = new System.Windows.Forms.DataGridView();
            this.addNewAuthorButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.allLiteratureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literatureSplitContainer)).BeginInit();
            this.literatureSplitContainer.Panel2.SuspendLayout();
            this.literatureSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literatureGridView)).BeginInit();
            this.categoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesSplitContainer)).BeginInit();
            this.cateroriesSplitContainer.Panel2.SuspendLayout();
            this.cateroriesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesGridView)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsSplitContainer)).BeginInit();
            this.authorsSplitContainer.Panel1.SuspendLayout();
            this.authorsSplitContainer.Panel2.SuspendLayout();
            this.authorsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.allLiteratureTab);
            this.tabControl.Controls.Add(this.categoriesTab);
            this.tabControl.Controls.Add(this.tabAuthors);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(903, 515);
            this.tabControl.TabIndex = 0;
            // 
            // allLiteratureTab
            // 
            this.allLiteratureTab.Controls.Add(this.literatureSplitContainer);
            this.allLiteratureTab.Location = new System.Drawing.Point(4, 25);
            this.allLiteratureTab.Name = "allLiteratureTab";
            this.allLiteratureTab.Padding = new System.Windows.Forms.Padding(3);
            this.allLiteratureTab.Size = new System.Drawing.Size(895, 486);
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
            this.literatureSplitContainer.Size = new System.Drawing.Size(889, 480);
            this.literatureSplitContainer.SplitterDistance = 150;
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
            this.literatureGridView.Size = new System.Drawing.Size(889, 320);
            this.literatureGridView.TabIndex = 0;
            // 
            // categoriesTab
            // 
            this.categoriesTab.Controls.Add(this.cateroriesSplitContainer);
            this.categoriesTab.Location = new System.Drawing.Point(4, 25);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTab.Size = new System.Drawing.Size(895, 486);
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
            // cateroriesSplitContainer.Panel2
            // 
            this.cateroriesSplitContainer.Panel2.Controls.Add(this.cateroriesGridView);
            this.cateroriesSplitContainer.Size = new System.Drawing.Size(889, 480);
            this.cateroriesSplitContainer.SplitterDistance = 150;
            this.cateroriesSplitContainer.TabIndex = 0;
            // 
            // cateroriesGridView
            // 
            this.cateroriesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cateroriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cateroriesGridView.Location = new System.Drawing.Point(3, 3);
            this.cateroriesGridView.Name = "cateroriesGridView";
            this.cateroriesGridView.RowHeadersWidth = 51;
            this.cateroriesGridView.RowTemplate.Height = 24;
            this.cateroriesGridView.Size = new System.Drawing.Size(883, 320);
            this.cateroriesGridView.TabIndex = 0;
            // 
            // tabAuthors
            // 
            this.tabAuthors.Controls.Add(this.authorsSplitContainer);
            this.tabAuthors.Location = new System.Drawing.Point(4, 25);
            this.tabAuthors.Name = "tabAuthors";
            this.tabAuthors.Size = new System.Drawing.Size(895, 486);
            this.tabAuthors.TabIndex = 2;
            this.tabAuthors.Text = "Authors";
            this.tabAuthors.UseVisualStyleBackColor = true;
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
            this.authorsSplitContainer.Size = new System.Drawing.Size(895, 486);
            this.authorsSplitContainer.SplitterDistance = 150;
            this.authorsSplitContainer.TabIndex = 0;
            // 
            // authorsGridView
            // 
            this.authorsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsGridView.Location = new System.Drawing.Point(3, 3);
            this.authorsGridView.Name = "authorsGridView";
            this.authorsGridView.RowHeadersWidth = 51;
            this.authorsGridView.RowTemplate.Height = 24;
            this.authorsGridView.Size = new System.Drawing.Size(889, 326);
            this.authorsGridView.TabIndex = 0;
            // 
            // addNewAuthorButton
            // 
            this.addNewAuthorButton.Location = new System.Drawing.Point(736, 16);
            this.addNewAuthorButton.Name = "addNewAuthorButton";
            this.addNewAuthorButton.Size = new System.Drawing.Size(137, 32);
            this.addNewAuthorButton.TabIndex = 0;
            this.addNewAuthorButton.Text = "Add New Author";
            this.addNewAuthorButton.UseVisualStyleBackColor = true;
            this.addNewAuthorButton.Click += new System.EventHandler(this.AddNewAuthorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 539);
            this.Controls.Add(this.tabControl);
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
            this.cateroriesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesSplitContainer)).EndInit();
            this.cateroriesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cateroriesGridView)).EndInit();
            this.tabAuthors.ResumeLayout(false);
            this.authorsSplitContainer.Panel1.ResumeLayout(false);
            this.authorsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsSplitContainer)).EndInit();
            this.authorsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allLiteratureTab;
        private System.Windows.Forms.TabPage categoriesTab;
        private System.Windows.Forms.SplitContainer literatureSplitContainer;
        private System.Windows.Forms.DataGridView literatureGridView;
        private System.Windows.Forms.TabPage tabAuthors;
        private System.Windows.Forms.SplitContainer authorsSplitContainer;
        private System.Windows.Forms.DataGridView authorsGridView;
        private System.Windows.Forms.SplitContainer cateroriesSplitContainer;
        private System.Windows.Forms.DataGridView cateroriesGridView;
        private System.Windows.Forms.Button addNewAuthorButton;
    }
}