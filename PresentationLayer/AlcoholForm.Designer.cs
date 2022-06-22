
namespace PresentationLayer
{
    partial class AlcoholForm
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
            this.AlcoholDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.IngredientBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.BushidoBox = new System.Windows.Forms.TextBox();
            this.OnyxBox = new System.Windows.Forms.TextBox();
            this.SecretsBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlcoholDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AlcoholDataGridView
            // 
            this.AlcoholDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlcoholDataGridView.Location = new System.Drawing.Point(251, 12);
            this.AlcoholDataGridView.Name = "AlcoholDataGridView";
            this.AlcoholDataGridView.RowTemplate.Height = 25;
            this.AlcoholDataGridView.Size = new System.Drawing.Size(537, 250);
            this.AlcoholDataGridView.TabIndex = 0;
            this.AlcoholDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlcoholDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main ingredient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bushido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Onyx";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(385, 305);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(505, 305);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(625, 305);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Secrets";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(120, 22);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(100, 23);
            this.TitleBox.TabIndex = 12;
            // 
            // IngredientBox
            // 
            this.IngredientBox.Location = new System.Drawing.Point(120, 72);
            this.IngredientBox.Name = "IngredientBox";
            this.IngredientBox.Size = new System.Drawing.Size(100, 23);
            this.IngredientBox.TabIndex = 13;
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(120, 122);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(100, 23);
            this.CountryBox.TabIndex = 14;
            // 
            // BushidoBox
            // 
            this.BushidoBox.Location = new System.Drawing.Point(120, 222);
            this.BushidoBox.Name = "BushidoBox";
            this.BushidoBox.Size = new System.Drawing.Size(100, 23);
            this.BushidoBox.TabIndex = 15;
            // 
            // OnyxBox
            // 
            this.OnyxBox.Location = new System.Drawing.Point(120, 272);
            this.OnyxBox.Name = "OnyxBox";
            this.OnyxBox.Size = new System.Drawing.Size(100, 23);
            this.OnyxBox.TabIndex = 16;
            // 
            // SecretsBox
            // 
            this.SecretsBox.Location = new System.Drawing.Point(120, 322);
            this.SecretsBox.Name = "SecretsBox";
            this.SecretsBox.Size = new System.Drawing.Size(100, 23);
            this.SecretsBox.TabIndex = 17;
            // 
            // AlcoholForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecretsBox);
            this.Controls.Add(this.OnyxBox);
            this.Controls.Add(this.BushidoBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.IngredientBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlcoholDataGridView);
            this.Name = "AlcoholForm";
            this.Text = "AlcoholForm";
            ((System.ComponentModel.ISupportInitialize)(this.AlcoholDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AlcoholDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox IngredientBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox BushidoBox;
        private System.Windows.Forms.TextBox OnyxBox;
        private System.Windows.Forms.TextBox SecretsBox;
    }
}