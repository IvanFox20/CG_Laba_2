namespace CG_Laba_2
{
    partial class Menu
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
            this.transformationsButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transformationsButton
            // 
            this.transformationsButton.Location = new System.Drawing.Point(172, 202);
            this.transformationsButton.Name = "transformationsButton";
            this.transformationsButton.Size = new System.Drawing.Size(149, 23);
            this.transformationsButton.TabIndex = 0;
            this.transformationsButton.Text = "Преобразования";
            this.transformationsButton.UseVisualStyleBackColor = true;
            this.transformationsButton.Click += new System.EventHandler(this.transformationsButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.Location = new System.Drawing.Point(464, 202);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(75, 23);
            this.gameButton.TabIndex = 1;
            this.gameButton.Text = "Игра";
            this.gameButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.transformationsButton);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button transformationsButton;

        private System.Windows.Forms.Button gameButton;

        #endregion
    }
}