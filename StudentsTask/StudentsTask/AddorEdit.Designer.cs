namespace StudentsTask
{
    partial class AddorEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IndexNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.IndexNumberLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(134, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(155, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko: ";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(134, 121);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(155, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nr Indeksu: ";
            // 
            // IndexNumberTextBox
            // 
            this.IndexNumberTextBox.Location = new System.Drawing.Point(134, 159);
            this.IndexNumberTextBox.Name = "IndexNumberTextBox";
            this.IndexNumberTextBox.Size = new System.Drawing.Size(155, 20);
            this.IndexNumberTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia: ";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(134, 197);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(155, 20);
            this.DateOfBirthTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ocena: ";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(134, 288);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 29);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(215, 288);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 29);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID: ";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.IDTextBox.Location = new System.Drawing.Point(134, 41);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(155, 20);
            this.IDTextBox.TabIndex = 13;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.NameLabel.Location = new System.Drawing.Point(125, 104);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(164, 13);
            this.NameLabel.TabIndex = 49;
            this.NameLabel.Text = "To pole nie może być puste!";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.NameLabel.Visible = false;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.SurnameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SurnameLabel.Location = new System.Drawing.Point(125, 144);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(164, 13);
            this.SurnameLabel.TabIndex = 50;
            this.SurnameLabel.Text = "To pole nie może być puste!";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.SurnameLabel.Visible = false;
            // 
            // IndexNumberLabel
            // 
            this.IndexNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IndexNumberLabel.AutoSize = true;
            this.IndexNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.IndexNumberLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.IndexNumberLabel.Location = new System.Drawing.Point(125, 181);
            this.IndexNumberLabel.Name = "IndexNumberLabel";
            this.IndexNumberLabel.Size = new System.Drawing.Size(164, 13);
            this.IndexNumberLabel.TabIndex = 51;
            this.IndexNumberLabel.Text = "To pole nie może być puste!";
            this.IndexNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.IndexNumberLabel.Visible = false;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(125, 220);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(164, 13);
            this.DateOfBirthLabel.TabIndex = 52;
            this.DateOfBirthLabel.Text = "To pole nie może być puste!";
            this.DateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DateOfBirthLabel.Visible = false;
            // 
            // MarkLabel
            // 
            this.MarkLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.MarkLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.MarkLabel.Location = new System.Drawing.Point(125, 261);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(172, 13);
            this.MarkLabel.TabIndex = 53;
            this.MarkLabel.Text = "Pamiętaj, aby uzupełnić pole!";
            this.MarkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.MarkLabel.Visible = false;
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Location = new System.Drawing.Point(134, 238);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(155, 20);
            this.MarkTextBox.TabIndex = 9;
            // 
            // AddorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(369, 379);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.IndexNumberLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateOfBirthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IndexNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddorEdit";
            this.Text = "Dodaj";
            this.Load += new System.EventHandler(this.AddorEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IndexNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label IndexNumberLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.TextBox MarkTextBox;
    }
}