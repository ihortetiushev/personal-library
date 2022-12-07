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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.authorsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.authorsGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.allLiteratureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsSplitContainer)).BeginInit();
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
            this.allLiteratureTab.Controls.Add(this.splitContainer1);
            this.allLiteratureTab.Location = new System.Drawing.Point(4, 25);
            this.allLiteratureTab.Name = "allLiteratureTab";
            this.allLiteratureTab.Padding = new System.Windows.Forms.Padding(3);
            this.allLiteratureTab.Size = new System.Drawing.Size(768, 397);
            this.allLiteratureTab.TabIndex = 0;
            this.allLiteratureTab.Text = "All Literature";
            this.allLiteratureTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(762, 391);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoriesTab
            // 
            this.categoriesTab.Location = new System.Drawing.Point(4, 25);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTab.Size = new System.Drawing.Size(768, 397);
            this.categoriesTab.TabIndex = 1;
            this.categoriesTab.Text = "Categories";
            this.categoriesTab.UseVisualStyleBackColor = true;
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
            // authorsSplitContainer.Panel2
            // 
            this.authorsSplitContainer.Panel2.Controls.Add(this.authorsGridView);
            this.authorsSplitContainer.Size = new System.Drawing.Size(895, 486);
            this.authorsSplitContainer.SplitterDistance = 181;
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
            this.authorsGridView.Size = new System.Drawing.Size(864, 295);
            this.authorsGridView.TabIndex = 0;
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAuthors.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabAuthors;
        private System.Windows.Forms.SplitContainer authorsSplitContainer;
        private System.Windows.Forms.DataGridView authorsGridView;
    }
}