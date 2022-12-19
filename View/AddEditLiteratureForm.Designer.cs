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
            this.label1 = new System.Windows.Forms.Label();
            this.removeAuthorButton = new System.Windows.Forms.Button();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.commentLable = new System.Windows.Forms.Label();
            this.commentText = new System.Windows.Forms.RichTextBox();
            this.availabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.originCommentText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inLibrarySince = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.publishDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.publisherText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.selectCategoryButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.RichTextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.removeAuthorButton);
            this.splitContainer1.Panel1.Controls.Add(this.addAuthorButton);
            this.splitContainer1.Panel1.Controls.Add(this.commentLable);
            this.splitContainer1.Panel1.Controls.Add(this.commentText);
            this.splitContainer1.Panel1.Controls.Add(this.availabilityCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.originCommentText);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.inLibrarySince);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.publishDate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.publisherText);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.isbnText);
            this.splitContainer1.Panel1.Controls.Add(this.isbnLabel);
            this.splitContainer1.Panel1.Controls.Add(this.categoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.selectCategoryButton);
            this.splitContainer1.Panel1.Controls.Add(this.titleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.titleText);
            this.splitContainer1.Panel1.Controls.Add(this.cancelSavingLiteratureButton);
            this.splitContainer1.Panel1.Controls.Add(this.saveLiteratureButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.literatureAuthorsGridView);
            this.splitContainer1.Size = new System.Drawing.Size(812, 585);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Authors";
            // 
            // removeAuthorButton
            // 
            this.removeAuthorButton.Location = new System.Drawing.Point(150, 443);
            this.removeAuthorButton.Name = "removeAuthorButton";
            this.removeAuthorButton.Size = new System.Drawing.Size(114, 23);
            this.removeAuthorButton.TabIndex = 22;
            this.removeAuthorButton.Text = "Remove Author";
            this.removeAuthorButton.UseVisualStyleBackColor = true;
            this.removeAuthorButton.Click += new System.EventHandler(this.RemoveAuthorButton_Click);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(28, 443);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(102, 23);
            this.addAuthorButton.TabIndex = 21;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // commentLable
            // 
            this.commentLable.AutoSize = true;
            this.commentLable.Location = new System.Drawing.Point(563, 349);
            this.commentLable.Name = "commentLable";
            this.commentLable.Size = new System.Drawing.Size(64, 16);
            this.commentLable.TabIndex = 20;
            this.commentLable.Text = "Comment";
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(28, 374);
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(599, 53);
            this.commentText.TabIndex = 19;
            this.commentText.Text = "";
            // 
            // availabilityCheckBox
            // 
            this.availabilityCheckBox.AutoSize = true;
            this.availabilityCheckBox.Checked = true;
            this.availabilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.availabilityCheckBox.Location = new System.Drawing.Point(28, 348);
            this.availabilityCheckBox.Name = "availabilityCheckBox";
            this.availabilityCheckBox.Size = new System.Drawing.Size(129, 20);
            this.availabilityCheckBox.TabIndex = 18;
            this.availabilityCheckBox.Text = "Is Available Now";
            this.availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // originCommentText
            // 
            this.originCommentText.Location = new System.Drawing.Point(28, 278);
            this.originCommentText.Name = "originCommentText";
            this.originCommentText.Size = new System.Drawing.Size(599, 53);
            this.originCommentText.TabIndex = 17;
            this.originCommentText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Comment On Literature Origin (purchase place and price or gift  etc..)";
            // 
            // inLibrarySince
            // 
            this.inLibrarySince.CustomFormat = " ";
            this.inLibrarySince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inLibrarySince.Location = new System.Drawing.Point(214, 227);
            this.inLibrarySince.Name = "inLibrarySince";
            this.inLibrarySince.ShowCheckBox = true;
            this.inLibrarySince.Size = new System.Drawing.Size(140, 22);
            this.inLibrarySince.TabIndex = 15;
            this.inLibrarySince.Value = new System.DateTime(2022, 12, 17, 0, 0, 0, 0);
            this.inLibrarySince.ValueChanged += new System.EventHandler(this.InLibrarySince_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "In Private Library Since";
            // 
            // publishDate
            // 
            this.publishDate.CustomFormat = " ";
            this.publishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.publishDate.Location = new System.Drawing.Point(28, 227);
            this.publishDate.Name = "publishDate";
            this.publishDate.ShowCheckBox = true;
            this.publishDate.Size = new System.Drawing.Size(102, 22);
            this.publishDate.TabIndex = 13;
            this.publishDate.Value = new System.DateTime(2022, 12, 17, 0, 0, 0, 0);
            this.publishDate.ValueChanged += new System.EventHandler(this.PublishDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Publish Date";
            // 
            // publisherText
            // 
            this.publisherText.Location = new System.Drawing.Point(214, 167);
            this.publisherText.Name = "publisherText";
            this.publisherText.Size = new System.Drawing.Size(413, 22);
            this.publisherText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Publisher";
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(28, 167);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(174, 22);
            this.isbnText.TabIndex = 7;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(25, 148);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(38, 16);
            this.isbnLabel.TabIndex = 6;
            this.isbnLabel.Text = "ISBN";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(133, 37);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(203, 16);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "No Category Has Been Selected";
            // 
            // selectCategoryButton
            // 
            this.selectCategoryButton.Location = new System.Drawing.Point(28, 30);
            this.selectCategoryButton.Name = "selectCategoryButton";
            this.selectCategoryButton.Size = new System.Drawing.Size(82, 27);
            this.selectCategoryButton.TabIndex = 4;
            this.selectCategoryButton.Text = "Category";
            this.selectCategoryButton.UseVisualStyleBackColor = true;
            this.selectCategoryButton.Click += new System.EventHandler(this.SelectCategoryButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(25, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(28, 82);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(599, 53);
            this.titleText.TabIndex = 2;
            this.titleText.Text = "";
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
            this.saveLiteratureButton.Location = new System.Drawing.Point(682, 34);
            this.saveLiteratureButton.Name = "saveLiteratureButton";
            this.saveLiteratureButton.Size = new System.Drawing.Size(82, 23);
            this.saveLiteratureButton.TabIndex = 0;
            this.saveLiteratureButton.Text = "Ok";
            this.saveLiteratureButton.UseVisualStyleBackColor = true;
            this.saveLiteratureButton.Click += new System.EventHandler(this.SaveLiteratureButton_Click);
            // 
            // literatureAuthorsGridView
            // 
            this.literatureAuthorsGridView.AllowUserToAddRows = false;
            this.literatureAuthorsGridView.AllowUserToDeleteRows = false;
            this.literatureAuthorsGridView.AllowUserToResizeColumns = false;
            this.literatureAuthorsGridView.AllowUserToResizeRows = false;
            this.literatureAuthorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.literatureAuthorsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.literatureAuthorsGridView.Location = new System.Drawing.Point(0, 0);
            this.literatureAuthorsGridView.Name = "literatureAuthorsGridView";
            this.literatureAuthorsGridView.ReadOnly = true;
            this.literatureAuthorsGridView.RowHeadersVisible = false;
            this.literatureAuthorsGridView.RowHeadersWidth = 51;
            this.literatureAuthorsGridView.RowTemplate.Height = 24;
            this.literatureAuthorsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.literatureAuthorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.literatureAuthorsGridView.Size = new System.Drawing.Size(812, 96);
            this.literatureAuthorsGridView.TabIndex = 0;
            // 
            // AddEditLiteratureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 585);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddEditLiteratureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditLiteratureForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox titleText;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button selectCategoryButton;
        private System.Windows.Forms.DateTimePicker publishDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publisherText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inLibrarySince;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox originCommentText;
        private System.Windows.Forms.RichTextBox commentText;
        private System.Windows.Forms.CheckBox availabilityCheckBox;
        private System.Windows.Forms.Button removeAuthorButton;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Label commentLable;
        private System.Windows.Forms.Label label1;
    }
}