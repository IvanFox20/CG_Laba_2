namespace CG_Laba_2
{
    partial class Ping_Pong
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
            this.gameOver_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOver_label
            // 
            this.gameOver_label.AutoSize = true;
            this.gameOver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameOver_label.Location = new System.Drawing.Point(285, 223);
            this.gameOver_label.Name = "gameOver_label";
            this.gameOver_label.Size = new System.Drawing.Size(506, 73);
            this.gameOver_label.TabIndex = 0;
            this.gameOver_label.Text = "Игра окончена!";
            this.gameOver_label.Visible = false;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_label.Location = new System.Drawing.Point(904, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(68, 20);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Score: 0";
            // 
            // Ping_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.gameOver_label);
            this.Name = "Ping_Pong";
            this.Text = "Ping_Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ping_PongFormPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOver_label;
        private System.Windows.Forms.Label score_label;
    }
}