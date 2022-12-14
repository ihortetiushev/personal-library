namespace PersonalLibrary
{
    partial class AddEditCategoryForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelSaveCategoryButton = new System.Windows.Forms.Button();
            this.saveCaterogyButton = new System.Windows.Forms.Button();
            this.categoryDescriptionInput = new System.Windows.Forms.RichTextBox();
            this.caterogyNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category Name";
            // 
            // cancelSaveCategoryButton
            // 
            this.cancelSaveCategoryButton.Location = new System.Drawing.Point(187, 259);
            this.cancelSaveCategoryButton.Name = "cancelSaveCategoryButton";
            this.cancelSaveCategoryButton.Size = new System.Drawing.Size(80, 23);
            this.cancelSaveCategoryButton.TabIndex = 13;
            this.cancelSaveCategoryButton.Text = "Cancel";
            this.cancelSaveCategoryButton.UseVisualStyleBackColor = true;
            this.cancelSaveCategoryButton.Click += new System.EventHandler(this.CancelSaveCategoryButton_Click);
            // 
            // saveCaterogyButton
            // 
            this.saveCaterogyButton.Location = new System.Drawing.Point(83, 259);
            this.saveCaterogyButton.Name = "saveCaterogyButton";
            this.saveCaterogyButton.Size = new System.Drawing.Size(82, 23);
            this.saveCaterogyButton.TabIndex = 12;
            this.saveCaterogyButton.Text = "Ok";
            this.saveCaterogyButton.UseVisualStyleBackColor = true;
            this.saveCaterogyButton.Click += new System.EventHandler(this.SaveCaterogyButton_Click);
            // 
            // categoryDescriptionInput
            // 
            this.categoryDescriptionInput.Location = new System.Drawing.Point(83, 142);
            this.categoryDescriptionInput.Name = "categoryDescriptionInput";
            this.categoryDescriptionInput.Size = new System.Drawing.Size(184, 76);
            this.categoryDescriptionInput.TabIndex = 11;
            this.categoryDescriptionInput.Text = "";
            // 
            // caterogyNameInput
            // 
            this.caterogyNameInput.Location = new System.Drawing.Point(83, 72);
            this.caterogyNameInput.Name = "caterogyNameInput";
            this.caterogyNameInput.Size = new System.Drawing.Size(184, 22);
            this.caterogyNameInput.TabIndex = 9;
            // 
            // AddEditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelSaveCategoryButton);
            this.Controls.Add(this.saveCaterogyButton);
            this.Controls.Add(this.categoryDescriptionInput);
            this.Controls.Add(this.caterogyNameInput);
            this.Name = "AddEditCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelSaveCategoryButton;
        private System.Windows.Forms.Button saveCaterogyButton;
        private System.Windows.Forms.RichTextBox categoryDescriptionInput;
        private System.Windows.Forms.TextBox caterogyNameInput;
    }
}