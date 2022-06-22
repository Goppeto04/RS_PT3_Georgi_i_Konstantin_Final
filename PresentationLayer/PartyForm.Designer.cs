
namespace PresentationLayer
{
    partial class PartyForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DrinksListBox = new System.Windows.Forms.ListBox();
            this.MembersListBox = new System.Windows.Forms.ListBox();
            this.AddDrinksButton = new System.Windows.Forms.Button();
            this.AddMembersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(483, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Possible Members";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Available Drinks";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(98, 9);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(142, 23);
            this.TitleBox.TabIndex = 9;
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(98, 54);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(142, 23);
            this.LocationBox.TabIndex = 10;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(98, 101);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(142, 68);
            this.DescriptionBox.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 384);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(625, 305);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(505, 305);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(385, 305);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DrinksListBox
            // 
            this.DrinksListBox.FormattingEnabled = true;
            this.DrinksListBox.ItemHeight = 15;
            this.DrinksListBox.Location = new System.Drawing.Point(12, 190);
            this.DrinksListBox.Name = "DrinksListBox";
            this.DrinksListBox.Size = new System.Drawing.Size(120, 154);
            this.DrinksListBox.TabIndex = 16;
            this.DrinksListBox.SelectedValueChanged += new System.EventHandler(this.DrinkListBox_SelectedValueChanged);
            // 
            // MembersListBox
            // 
            this.MembersListBox.FormattingEnabled = true;
            this.MembersListBox.ItemHeight = 15;
            this.MembersListBox.Location = new System.Drawing.Point(163, 190);
            this.MembersListBox.Name = "MembersListBox";
            this.MembersListBox.Size = new System.Drawing.Size(120, 154);
            this.MembersListBox.TabIndex = 17;
            this.MembersListBox.SelectedValueChanged += new System.EventHandler(this.MembersListBox_SelectedValueChanged);
            // 
            // AddDrinksButton
            // 
            this.AddDrinksButton.Location = new System.Drawing.Point(12, 350);
            this.AddDrinksButton.Name = "AddDrinksButton";
            this.AddDrinksButton.Size = new System.Drawing.Size(93, 23);
            this.AddDrinksButton.TabIndex = 18;
            this.AddDrinksButton.Text = "Add drink";
            this.AddDrinksButton.UseVisualStyleBackColor = true;
            this.AddDrinksButton.Click += new System.EventHandler(this.AddDrinksButton_Click);
            // 
            // AddMembersButton
            // 
            this.AddMembersButton.Location = new System.Drawing.Point(163, 350);
            this.AddMembersButton.Name = "AddMembersButton";
            this.AddMembersButton.Size = new System.Drawing.Size(93, 23);
            this.AddMembersButton.TabIndex = 19;
            this.AddMembersButton.Text = "Add member";
            this.AddMembersButton.UseVisualStyleBackColor = true;
            this.AddMembersButton.Click += new System.EventHandler(this.AddMembersButton_Click);
            // 
            // PartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.AddMembersButton);
            this.Controls.Add(this.AddDrinksButton);
            this.Controls.Add(this.MembersListBox);
            this.Controls.Add(this.DrinksListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartyForm";
            this.Text = "PartyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ListBox DrinksListBox;
        private System.Windows.Forms.ListBox MembersListBox;
        private System.Windows.Forms.Button AddDrinksButton;
        private System.Windows.Forms.Button AddMembersButton;
    }
}