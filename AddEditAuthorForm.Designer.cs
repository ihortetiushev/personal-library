namespace PersonalLibrary
{
    partial class AddEditAuthorForm
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
            this.authorFirstNameInput = new System.Windows.Forms.TextBox();
            this.authorLastNameInput = new System.Windows.Forms.TextBox();
            this.authorCommentInput = new System.Windows.Forms.RichTextBox();
            this.saveAuthorButton = new System.Windows.Forms.Button();
            this.cancelSaveAutorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorFirstNameInput
            // 
            this.authorFirstNameInput.Location = new System.Drawing.Point(85, 54);
            this.authorFirstNameInput.Name = "authorFirstNameInput";
            this.authorFirstNameInput.Size = new System.Drawing.Size(184, 22);
            this.authorFirstNameInput.TabIndex = 0;
            // 
            // authorLastNameInput
            // 
            this.authorLastNameInput.Location = new System.Drawing.Point(85, 106);
            this.authorLastNameInput.Name = "authorLastNameInput";
            this.authorLastNameInput.Size = new System.Drawing.Size(184, 22);
            this.authorLastNameInput.TabIndex = 1;
            // 
            // authorCommentInput
            // 
            this.authorCommentInput.Location = new System.Drawing.Point(85, 167);
            this.authorCommentInput.Name = "authorCommentInput";
            this.authorCommentInput.Size = new System.Drawing.Size(184, 76);
            this.authorCommentInput.TabIndex = 3;
            this.authorCommentInput.Text = "";
            // 
            // saveAuthorButton
            // 
            this.saveAuthorButton.Location = new System.Drawing.Point(85, 284);
            this.saveAuthorButton.Name = "saveAuthorButton";
            this.saveAuthorButton.Size = new System.Drawing.Size(82, 23);
            this.saveAuthorButton.TabIndex = 4;
            this.saveAuthorButton.Text = "Ok";
            this.saveAuthorButton.UseVisualStyleBackColor = true;
            this.saveAuthorButton.Click += new System.EventHandler(this.SaveAuthorButton_Click);
            // 
            // cancelSaveAutorButton
            // 
            this.cancelSaveAutorButton.Location = new System.Drawing.Point(189, 284);
            this.cancelSaveAutorButton.Name = "cancelSaveAutorButton";
            this.cancelSaveAutorButton.Size = new System.Drawing.Size(80, 23);
            this.cancelSaveAutorButton.TabIndex = 5;
            this.cancelSaveAutorButton.Text = "Cancel";
            this.cancelSaveAutorButton.UseVisualStyleBackColor = true;
            this.cancelSaveAutorButton.Click += new System.EventHandler(this.CancelSaveAutorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comment";
            // 
            // AddEditAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelSaveAutorButton);
            this.Controls.Add(this.saveAuthorButton);
            this.Controls.Add(this.authorCommentInput);
            this.Controls.Add(this.authorLastNameInput);
            this.Controls.Add(this.authorFirstNameInput);
            this.Name = "AddEditAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorFirstNameInput;
        private System.Windows.Forms.TextBox authorLastNameInput;
        private System.Windows.Forms.RichTextBox authorCommentInput;
        private System.Windows.Forms.Button saveAuthorButton;
        private System.Windows.Forms.Button cancelSaveAutorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}