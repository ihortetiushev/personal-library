namespace personal_library.View
{
    partial class CategorySelectionForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.categorySelectionGridView = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorySelectionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel1.Controls.Add(this.okButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.categorySelectionGridView);
            this.splitContainer1.Size = new System.Drawing.Size(711, 525);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 0;
            // 
            // categorySelectionGridView
            // 
            this.categorySelectionGridView.AllowUserToAddRows = false;
            this.categorySelectionGridView.AllowUserToDeleteRows = false;
            this.categorySelectionGridView.AllowUserToResizeColumns = false;
            this.categorySelectionGridView.AllowUserToResizeRows = false;
            this.categorySelectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorySelectionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorySelectionGridView.Location = new System.Drawing.Point(0, 0);
            this.categorySelectionGridView.MultiSelect = false;
            this.categorySelectionGridView.Name = "categorySelectionGridView";
            this.categorySelectionGridView.ReadOnly = true;
            this.categorySelectionGridView.RowHeadersWidth = 51;
            this.categorySelectionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categorySelectionGridView.RowTemplate.Height = 24;
            this.categorySelectionGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categorySelectionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorySelectionGridView.Size = new System.Drawing.Size(711, 363);
            this.categorySelectionGridView.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(580, 25);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(97, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(580, 72);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CategorySelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 525);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CategorySelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Category And Press Ok Button";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categorySelectionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView categorySelectionGridView;
    }
}