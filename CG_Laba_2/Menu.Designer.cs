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
            this.transformationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transformationsButton.Location = new System.Drawing.Point(119, 176);
            this.transformationsButton.Name = "transformationsButton";
            this.transformationsButton.Size = new System.Drawing.Size(257, 74);
            this.transformationsButton.TabIndex = 0;
            this.transformationsButton.Text = "Преобразования";
            this.transformationsButton.UseVisualStyleBackColor = true;
            this.transformationsButton.Click += new System.EventHandler(this.transformationsButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameButton.Location = new System.Drawing.Point(412, 176);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(257, 74);
            this.gameButton.TabIndex = 1;
            this.gameButton.Text = "Игра";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
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