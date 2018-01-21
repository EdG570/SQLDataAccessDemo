namespace FormUI
{
    partial class DashBoard
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
            this.PeopleListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.firstNameInsertTextBox = new System.Windows.Forms.TextBox();
            this.firstNameInsertLabel = new System.Windows.Forms.Label();
            this.lastNameInsertTextBox = new System.Windows.Forms.TextBox();
            this.lastNameInsertLabel = new System.Windows.Forms.Label();
            this.emailInsertTextBox = new System.Windows.Forms.TextBox();
            this.emalInsertLabel = new System.Windows.Forms.Label();
            this.phoneNumInsertTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumInsertLabel = new System.Windows.Forms.Label();
            this.PersonInsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleListBox
            // 
            this.PeopleListBox.FormattingEnabled = true;
            this.PeopleListBox.Location = new System.Drawing.Point(33, 79);
            this.PeopleListBox.Name = "PeopleListBox";
            this.PeopleListBox.Size = new System.Drawing.Size(637, 147);
            this.PeopleListBox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(103, 47);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(133, 20);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(37, 50);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(249, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // firstNameInsertTextBox
            // 
            this.firstNameInsertTextBox.Location = new System.Drawing.Point(103, 271);
            this.firstNameInsertTextBox.Name = "firstNameInsertTextBox";
            this.firstNameInsertTextBox.Size = new System.Drawing.Size(133, 20);
            this.firstNameInsertTextBox.TabIndex = 1;
            // 
            // firstNameInsertLabel
            // 
            this.firstNameInsertLabel.AutoSize = true;
            this.firstNameInsertLabel.Location = new System.Drawing.Point(37, 274);
            this.firstNameInsertLabel.Name = "firstNameInsertLabel";
            this.firstNameInsertLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameInsertLabel.TabIndex = 2;
            this.firstNameInsertLabel.Text = "First Name";
            // 
            // lastNameInsertTextBox
            // 
            this.lastNameInsertTextBox.Location = new System.Drawing.Point(103, 297);
            this.lastNameInsertTextBox.Name = "lastNameInsertTextBox";
            this.lastNameInsertTextBox.Size = new System.Drawing.Size(133, 20);
            this.lastNameInsertTextBox.TabIndex = 1;
            // 
            // lastNameInsertLabel
            // 
            this.lastNameInsertLabel.AutoSize = true;
            this.lastNameInsertLabel.Location = new System.Drawing.Point(37, 300);
            this.lastNameInsertLabel.Name = "lastNameInsertLabel";
            this.lastNameInsertLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameInsertLabel.TabIndex = 2;
            this.lastNameInsertLabel.Text = "Last Name";
            // 
            // emailInsertTextBox
            // 
            this.emailInsertTextBox.Location = new System.Drawing.Point(103, 323);
            this.emailInsertTextBox.Name = "emailInsertTextBox";
            this.emailInsertTextBox.Size = new System.Drawing.Size(133, 20);
            this.emailInsertTextBox.TabIndex = 1;
            // 
            // emalInsertLabel
            // 
            this.emalInsertLabel.AutoSize = true;
            this.emalInsertLabel.Location = new System.Drawing.Point(37, 326);
            this.emalInsertLabel.Name = "emalInsertLabel";
            this.emalInsertLabel.Size = new System.Drawing.Size(32, 13);
            this.emalInsertLabel.TabIndex = 2;
            this.emalInsertLabel.Text = "Email";
            // 
            // phoneNumInsertTextBox
            // 
            this.phoneNumInsertTextBox.Location = new System.Drawing.Point(103, 349);
            this.phoneNumInsertTextBox.Name = "phoneNumInsertTextBox";
            this.phoneNumInsertTextBox.Size = new System.Drawing.Size(133, 20);
            this.phoneNumInsertTextBox.TabIndex = 1;
            // 
            // phoneNumInsertLabel
            // 
            this.phoneNumInsertLabel.AutoSize = true;
            this.phoneNumInsertLabel.Location = new System.Drawing.Point(37, 352);
            this.phoneNumInsertLabel.Name = "phoneNumInsertLabel";
            this.phoneNumInsertLabel.Size = new System.Drawing.Size(48, 13);
            this.phoneNumInsertLabel.TabIndex = 2;
            this.phoneNumInsertLabel.Text = "Phone #";
            // 
            // PersonInsertButton
            // 
            this.PersonInsertButton.Location = new System.Drawing.Point(161, 375);
            this.PersonInsertButton.Name = "PersonInsertButton";
            this.PersonInsertButton.Size = new System.Drawing.Size(75, 23);
            this.PersonInsertButton.TabIndex = 3;
            this.PersonInsertButton.Text = "Save";
            this.PersonInsertButton.UseVisualStyleBackColor = true;
            this.PersonInsertButton.Click += new System.EventHandler(this.PersonInsertButton_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 436);
            this.Controls.Add(this.PersonInsertButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.phoneNumInsertLabel);
            this.Controls.Add(this.emalInsertLabel);
            this.Controls.Add(this.lastNameInsertLabel);
            this.Controls.Add(this.firstNameInsertLabel);
            this.Controls.Add(this.phoneNumInsertTextBox);
            this.Controls.Add(this.emailInsertTextBox);
            this.Controls.Add(this.lastNameInsertTextBox);
            this.Controls.Add(this.firstNameInsertTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleListBox);
            this.Name = "DashBoard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox firstNameInsertTextBox;
        private System.Windows.Forms.Label firstNameInsertLabel;
        private System.Windows.Forms.TextBox lastNameInsertTextBox;
        private System.Windows.Forms.Label lastNameInsertLabel;
        private System.Windows.Forms.TextBox emailInsertTextBox;
        private System.Windows.Forms.Label emalInsertLabel;
        private System.Windows.Forms.TextBox phoneNumInsertTextBox;
        private System.Windows.Forms.Label phoneNumInsertLabel;
        private System.Windows.Forms.Button PersonInsertButton;
    }
}

