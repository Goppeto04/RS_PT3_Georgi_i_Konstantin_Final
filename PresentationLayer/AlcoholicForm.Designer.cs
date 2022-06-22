
namespace PresentationLayer
{
    partial class AlcoholicForm
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
            this.DrunkNameBox = new System.Windows.Forms.TextBox();
            this.FamilyBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlcoholicGridView = new System.Windows.Forms.DataGridView();
            this.AgeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DrinksListBox = new System.Windows.Forms.ListBox();
            this.AddingDrinksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlcoholicGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DrunkNameBox
            // 
            this.DrunkNameBox.Location = new System.Drawing.Point(98, 104);
            this.DrunkNameBox.Name = "DrunkNameBox";
            this.DrunkNameBox.Size = new System.Drawing.Size(142, 23);
            this.DrunkNameBox.TabIndex = 18;
            // 
            // FamilyBox
            // 
            this.FamilyBox.Location = new System.Drawing.Point(98, 57);
            this.FamilyBox.Name = "FamilyBox";
            this.FamilyBox.Size = new System.Drawing.Size(142, 23);
            this.FamilyBox.TabIndex = 17;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(98, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(142, 23);
            this.NameBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Drunk Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Family Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // AlcoholicGridView
            // 
            this.AlcoholicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlcoholicGridView.Location = new System.Drawing.Point(263, 12);
            this.AlcoholicGridView.Name = "AlcoholicGridView";
            this.AlcoholicGridView.RowTemplate.Height = 25;
            this.AlcoholicGridView.Size = new System.Drawing.Size(525, 254);
            this.AlcoholicGridView.TabIndex = 12;
            this.AlcoholicGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlcoholicGridView_CellClick);
            // 
            // AgeNumeric
            // 
            this.AgeNumeric.Location = new System.Drawing.Point(98, 147);
            this.AgeNumeric.Name = "AgeNumeric";
            this.AgeNumeric.Size = new System.Drawing.Size(58, 23);
            this.AgeNumeric.TabIndex = 19;
            this.AgeNumeric.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Age";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(625, 289);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(505, 289);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(385, 289);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 21;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DrinksListBox
            // 
            this.DrinksListBox.FormattingEnabled = true;
            this.DrinksListBox.ItemHeight = 15;
            this.DrinksListBox.Location = new System.Drawing.Point(12, 236);
            this.DrinksListBox.Name = "DrinksListBox";
            this.DrinksListBox.Size = new System.Drawing.Size(119, 139);
            this.DrinksListBox.TabIndex = 25;
            this.DrinksListBox.SelectedValueChanged += new System.EventHandler(this.DrinksListBox_SelectedValueChanged);
            // 
            // AddingDrinksButton
            // 
            this.AddingDrinksButton.Location = new System.Drawing.Point(11, 381);
            this.AddingDrinksButton.Name = "AddingDrinksButton";
            this.AddingDrinksButton.Size = new System.Drawing.Size(75, 23);
            this.AddingDrinksButton.TabIndex = 27;
            this.AddingDrinksButton.Text = "Add Drink";
            this.AddingDrinksButton.UseVisualStyleBackColor = true;
            this.AddingDrinksButton.Click += new System.EventHandler(this.AddingDrinksButton_Click);
            // 
            // AlcoholicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddingDrinksButton);
            this.Controls.Add(this.DrinksListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeNumeric);
            this.Controls.Add(this.DrunkNameBox);
            this.Controls.Add(this.FamilyBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlcoholicGridView);
            this.Name = "AlcoholicForm";
            this.Text = "AlcoholicForm";
            ((System.ComponentModel.ISupportInitialize)(this.AlcoholicGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DrunkNameBox;
        private System.Windows.Forms.TextBox FamilyBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AlcoholicGridView;
        private System.Windows.Forms.NumericUpDown AgeNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ListBox DrinksListBox;
        private System.Windows.Forms.Button AddingDrinksButton;
    }
}