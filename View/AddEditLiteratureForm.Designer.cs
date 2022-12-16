namespace PersonalLibrary.View
{
    partial class AddEditLiteratureForm
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
            this.cancelSavingLiteratureButton = new System.Windows.Forms.Button();
            this.saveLiteratureButton = new System.Windows.Forms.Button();
            this.literatureAuthorsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literatureAuthorsGridView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cancelSavingLiteratureButton);
            this.splitContainer1.Panel1.Controls.Add(this.saveLiteratureButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.literatureAuthorsGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // cancelSavingLiteratureButton
            // 
            this.cancelSavingLiteratureButton.Location = new System.Drawing.Point(682, 73);
            this.cancelSavingLiteratureButton.Name = "cancelSavingLiteratureButton";
            this.cancelSavingLiteratureButton.Size = new System.Drawing.Size(82, 23);
            this.cancelSavingLiteratureButton.TabIndex = 1;
            this.cancelSavingLiteratureButton.Text = "Cancel";
            this.cancelSavingLiteratureButton.UseVisualStyleBackColor = true;
            this.cancelSavingLiteratureButton.Click += new System.EventHandler(this.CancelSavingLiteratureButton_Click);
            // 
            // saveLiteratureButton
            // 
            this.saveLiteratureButton.Location = new System.Drawing.Point(682, 26);
            this.saveLiteratureButton.Name = "saveLiteratureButton";
            this.saveLiteratureButton.Size = new System.Drawing.Size(82, 23);
            this.saveLiteratureButton.TabIndex = 0;
            this.saveLiteratureButton.Text = "Ok";
            this.saveLiteratureButton.UseVisualStyleBackColor = true;
            this.saveLiteratureButton.Click += new System.EventHandler(this.SaveLiteratureButton_Click);
            // 
            // literatureAuthorsGridView
            // 
            this.literatureAuthorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.literatureAuthorsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.literatureAuthorsGridView.Location = new System.Drawing.Point(0, 0);
            this.literatureAuthorsGridView.Name = "literatureAuthorsGridView";
            this.literatureAuthorsGridView.RowHeadersWidth = 51;
            this.literatureAuthorsGridView.RowTemplate.Height = 24;
            this.literatureAuthorsGridView.Size = new System.Drawing.Size(800, 165);
            this.literatureAuthorsGridView.TabIndex = 0;
            // 
            // AddEditLiteratureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddEditLiteratureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditLiteratureForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.literatureAuthorsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cancelSavingLiteratureButton;
        private System.Windows.Forms.Button saveLiteratureButton;
        private System.Windows.Forms.DataGridView literatureAuthorsGridView;
    }
}