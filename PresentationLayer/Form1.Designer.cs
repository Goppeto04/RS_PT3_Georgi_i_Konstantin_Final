
namespace PresentationLayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AlcoholicButton = new System.Windows.Forms.Button();
            this.AlcoholButton = new System.Windows.Forms.Button();
            this.PartyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your Party Maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AlcoholicButton
            // 
            this.AlcoholicButton.Location = new System.Drawing.Point(12, 81);
            this.AlcoholicButton.Name = "AlcoholicButton";
            this.AlcoholicButton.Size = new System.Drawing.Size(75, 23);
            this.AlcoholicButton.TabIndex = 1;
            this.AlcoholicButton.Text = "Alcoholic";
            this.AlcoholicButton.UseVisualStyleBackColor = true;
            this.AlcoholicButton.Click += new System.EventHandler(this.AlcoholicButton_Click);
            // 
            // AlcoholButton
            // 
            this.AlcoholButton.Location = new System.Drawing.Point(12, 121);
            this.AlcoholButton.Name = "AlcoholButton";
            this.AlcoholButton.Size = new System.Drawing.Size(75, 23);
            this.AlcoholButton.TabIndex = 2;
            this.AlcoholButton.Text = "Alcohol";
            this.AlcoholButton.UseVisualStyleBackColor = true;
            this.AlcoholButton.Click += new System.EventHandler(this.AlcoholButton_Click);
            // 
            // PartyButton
            // 
            this.PartyButton.Location = new System.Drawing.Point(12, 161);
            this.PartyButton.Name = "PartyButton";
            this.PartyButton.Size = new System.Drawing.Size(75, 23);
            this.PartyButton.TabIndex = 3;
            this.PartyButton.Text = "Party";
            this.PartyButton.UseVisualStyleBackColor = true;
            this.PartyButton.Click += new System.EventHandler(this.PartyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.bushido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(112, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 272);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 241);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 334);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PartyButton);
            this.Controls.Add(this.AlcoholButton);
            this.Controls.Add(this.AlcoholicButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AlcoholicButton;
        private System.Windows.Forms.Button AlcoholButton;
        private System.Windows.Forms.Button PartyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton;
    }
}

