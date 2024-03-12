using System.ComponentModel;

namespace CG_Laba_2
{
    partial class Transformations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.draw_pictureBox = new System.Windows.Forms.PictureBox();
            this.transferX_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.transferX_label = new System.Windows.Forms.Label();
            this.restoration_button = new System.Windows.Forms.Button();
            this.transferY_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.transferY_label = new System.Windows.Forms.Label();
            this.reflectionX_button = new System.Windows.Forms.Button();
            this.reflectionY_button = new System.Windows.Forms.Button();
            this.reflectionYX_button = new System.Windows.Forms.Button();
            this.scalingX_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scalingY_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scalingX_label = new System.Windows.Forms.Label();
            this.scalingY_label = new System.Windows.Forms.Label();
            this.rotationCentre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationCentre_button = new System.Windows.Forms.Label();
            this.rotationPoint_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationPoint_label = new System.Windows.Forms.Label();
            this.rotationPointX_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationPointY_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationPointX_label = new System.Windows.Forms.Label();
            this.rotationPointY_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.draw_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferX_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferY_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingX_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingY_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationCentre_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPoint_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPointX_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPointY_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // draw_pictureBox
            // 
            this.draw_pictureBox.Location = new System.Drawing.Point(2, 1);
            this.draw_pictureBox.Name = "draw_pictureBox";
            this.draw_pictureBox.Size = new System.Drawing.Size(600, 600);
            this.draw_pictureBox.TabIndex = 2;
            this.draw_pictureBox.TabStop = false;
            // 
            // transferX_numericUpDown
            // 
            this.transferX_numericUpDown.DecimalPlaces = 1;
            this.transferX_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.transferX_numericUpDown.Location = new System.Drawing.Point(880, 12);
            this.transferX_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.transferX_numericUpDown.Name = "transferX_numericUpDown";
            this.transferX_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.transferX_numericUpDown.TabIndex = 6;
            this.transferX_numericUpDown.ValueChanged += new System.EventHandler(this.transferX_numericUpDown_ValueChanged);
            // 
            // transferX_label
            // 
            this.transferX_label.AutoSize = true;
            this.transferX_label.Location = new System.Drawing.Point(719, 14);
            this.transferX_label.Name = "transferX_label";
            this.transferX_label.Size = new System.Drawing.Size(123, 13);
            this.transferX_label.TabIndex = 7;
            this.transferX_label.Text = "Перенос вдоль оси OX";
            // 
            // restoration_button
            // 
            this.restoration_button.Location = new System.Drawing.Point(722, 541);
            this.restoration_button.Name = "restoration_button";
            this.restoration_button.Size = new System.Drawing.Size(278, 60);
            this.restoration_button.TabIndex = 8;
            this.restoration_button.Text = "Вернуть исходное значение фигуры";
            this.restoration_button.UseVisualStyleBackColor = true;
            this.restoration_button.Click += new System.EventHandler(this.restoration_button_Click);
            // 
            // transferY_numericUpDown
            // 
            this.transferY_numericUpDown.DecimalPlaces = 1;
            this.transferY_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.transferY_numericUpDown.Location = new System.Drawing.Point(880, 38);
            this.transferY_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.transferY_numericUpDown.Name = "transferY_numericUpDown";
            this.transferY_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.transferY_numericUpDown.TabIndex = 9;
            this.transferY_numericUpDown.ValueChanged += new System.EventHandler(this.transferY_numericUpDown_ValueChanged);
            // 
            // transferY_label
            // 
            this.transferY_label.AutoSize = true;
            this.transferY_label.Location = new System.Drawing.Point(719, 40);
            this.transferY_label.Name = "transferY_label";
            this.transferY_label.Size = new System.Drawing.Size(123, 13);
            this.transferY_label.TabIndex = 10;
            this.transferY_label.Text = "Перенос вдоль оси OY";
            // 
            // reflectionX_button
            // 
            this.reflectionX_button.Location = new System.Drawing.Point(722, 64);
            this.reflectionX_button.Name = "reflectionX_button";
            this.reflectionX_button.Size = new System.Drawing.Size(278, 26);
            this.reflectionX_button.TabIndex = 11;
            this.reflectionX_button.Text = "Отражение относительно оси OX";
            this.reflectionX_button.UseVisualStyleBackColor = true;
            this.reflectionX_button.Click += new System.EventHandler(this.reflectionX_button_Click);
            // 
            // reflectionY_button
            // 
            this.reflectionY_button.Location = new System.Drawing.Point(722, 96);
            this.reflectionY_button.Name = "reflectionY_button";
            this.reflectionY_button.Size = new System.Drawing.Size(278, 26);
            this.reflectionY_button.TabIndex = 12;
            this.reflectionY_button.Text = "Отражение относительно оси OY";
            this.reflectionY_button.UseVisualStyleBackColor = true;
            this.reflectionY_button.Click += new System.EventHandler(this.reflectionY_button_Click);
            // 
            // reflectionYX_button
            // 
            this.reflectionYX_button.Location = new System.Drawing.Point(722, 128);
            this.reflectionYX_button.Name = "reflectionYX_button";
            this.reflectionYX_button.Size = new System.Drawing.Size(278, 26);
            this.reflectionYX_button.TabIndex = 13;
            this.reflectionYX_button.Text = "Отражение относительно  прямой Y = X";
            this.reflectionYX_button.UseVisualStyleBackColor = true;
            this.reflectionYX_button.Click += new System.EventHandler(this.reflectionYX_button_Click);
            // 
            // scalingX_numericUpDown
            // 
            this.scalingX_numericUpDown.DecimalPlaces = 2;
            this.scalingX_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.scalingX_numericUpDown.Location = new System.Drawing.Point(880, 160);
            this.scalingX_numericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.scalingX_numericUpDown.Name = "scalingX_numericUpDown";
            this.scalingX_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.scalingX_numericUpDown.TabIndex = 14;
            this.scalingX_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scalingX_numericUpDown.ValueChanged += new System.EventHandler(this.scalingX_numericUpDown_ValueChanged);
            // 
            // scalingY_numericUpDown
            // 
            this.scalingY_numericUpDown.DecimalPlaces = 2;
            this.scalingY_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.scalingY_numericUpDown.Location = new System.Drawing.Point(880, 186);
            this.scalingY_numericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.scalingY_numericUpDown.Name = "scalingY_numericUpDown";
            this.scalingY_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.scalingY_numericUpDown.TabIndex = 15;
            this.scalingY_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scalingY_numericUpDown.ValueChanged += new System.EventHandler(this.scalingY_numericUpDown_ValueChanged);
            // 
            // scalingX_label
            // 
            this.scalingX_label.AutoSize = true;
            this.scalingX_label.Location = new System.Drawing.Point(719, 162);
            this.scalingX_label.Name = "scalingX_label";
            this.scalingX_label.Size = new System.Drawing.Size(155, 13);
            this.scalingX_label.TabIndex = 16;
            this.scalingX_label.Text = "Масштабирование по оси OX";
            // 
            // scalingY_label
            // 
            this.scalingY_label.AutoSize = true;
            this.scalingY_label.Location = new System.Drawing.Point(719, 188);
            this.scalingY_label.Name = "scalingY_label";
            this.scalingY_label.Size = new System.Drawing.Size(155, 13);
            this.scalingY_label.TabIndex = 17;
            this.scalingY_label.Text = "Масштабирование по оси OY";
            // 
            // rotationCentre_numericUpDown
            // 
            this.rotationCentre_numericUpDown.Location = new System.Drawing.Point(880, 212);
            this.rotationCentre_numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationCentre_numericUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotationCentre_numericUpDown.Name = "rotationCentre_numericUpDown";
            this.rotationCentre_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotationCentre_numericUpDown.TabIndex = 18;
            this.rotationCentre_numericUpDown.ValueChanged += new System.EventHandler(this.rotationCentre_numericUpDown_ValueChanged);
            // 
            // rotationCentre_button
            // 
            this.rotationCentre_button.AutoSize = true;
            this.rotationCentre_button.Location = new System.Drawing.Point(719, 214);
            this.rotationCentre_button.Name = "rotationCentre_button";
            this.rotationCentre_button.Size = new System.Drawing.Size(161, 13);
            this.rotationCentre_button.TabIndex = 19;
            this.rotationCentre_button.Text = "Поворот относительно центра";
            // 
            // rotationPoint_numericUpDown
            // 
            this.rotationPoint_numericUpDown.Location = new System.Drawing.Point(880, 240);
            this.rotationPoint_numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationPoint_numericUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotationPoint_numericUpDown.Name = "rotationPoint_numericUpDown";
            this.rotationPoint_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotationPoint_numericUpDown.TabIndex = 20;
            this.rotationPoint_numericUpDown.ValueChanged += new System.EventHandler(this.rotationPoint_numericUpDown_ValueChanged);
            // 
            // rotationPoint_label
            // 
            this.rotationPoint_label.AutoSize = true;
            this.rotationPoint_label.Location = new System.Drawing.Point(719, 240);
            this.rotationPoint_label.Name = "rotationPoint_label";
            this.rotationPoint_label.Size = new System.Drawing.Size(154, 13);
            this.rotationPoint_label.TabIndex = 21;
            this.rotationPoint_label.Text = "Поворот относительно точки";
            // 
            // rotationPointX_numericUpDown
            // 
            this.rotationPointX_numericUpDown.DecimalPlaces = 1;
            this.rotationPointX_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rotationPointX_numericUpDown.Location = new System.Drawing.Point(747, 256);
            this.rotationPointX_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotationPointX_numericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotationPointX_numericUpDown.Name = "rotationPointX_numericUpDown";
            this.rotationPointX_numericUpDown.Size = new System.Drawing.Size(46, 20);
            this.rotationPointX_numericUpDown.TabIndex = 22;
            this.rotationPointX_numericUpDown.ValueChanged += new System.EventHandler(this.rotationPointX_numericUpDown_ValueChanged);
            // 
            // rotationPointY_numericUpDown
            // 
            this.rotationPointY_numericUpDown.DecimalPlaces = 1;
            this.rotationPointY_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rotationPointY_numericUpDown.Location = new System.Drawing.Point(819, 256);
            this.rotationPointY_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rotationPointY_numericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.rotationPointY_numericUpDown.Name = "rotationPointY_numericUpDown";
            this.rotationPointY_numericUpDown.Size = new System.Drawing.Size(43, 20);
            this.rotationPointY_numericUpDown.TabIndex = 23;
            this.rotationPointY_numericUpDown.ValueChanged += new System.EventHandler(this.rotationPointY_numericUpDown_ValueChanged);
            // 
            // rotationPointX_label
            // 
            this.rotationPointX_label.AutoSize = true;
            this.rotationPointX_label.Location = new System.Drawing.Point(727, 258);
            this.rotationPointX_label.Name = "rotationPointX_label";
            this.rotationPointX_label.Size = new System.Drawing.Size(14, 13);
            this.rotationPointX_label.TabIndex = 24;
            this.rotationPointX_label.Text = "X";
            // 
            // rotationPointY_label
            // 
            this.rotationPointY_label.AutoSize = true;
            this.rotationPointY_label.Location = new System.Drawing.Point(799, 258);
            this.rotationPointY_label.Name = "rotationPointY_label";
            this.rotationPointY_label.Size = new System.Drawing.Size(14, 13);
            this.rotationPointY_label.TabIndex = 25;
            this.rotationPointY_label.Text = "Y";
            // 
            // Transformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 614);
            this.Controls.Add(this.rotationPointY_label);
            this.Controls.Add(this.rotationPointX_label);
            this.Controls.Add(this.rotationPointY_numericUpDown);
            this.Controls.Add(this.rotationPointX_numericUpDown);
            this.Controls.Add(this.rotationPoint_label);
            this.Controls.Add(this.rotationPoint_numericUpDown);
            this.Controls.Add(this.rotationCentre_button);
            this.Controls.Add(this.rotationCentre_numericUpDown);
            this.Controls.Add(this.scalingY_label);
            this.Controls.Add(this.scalingX_label);
            this.Controls.Add(this.scalingY_numericUpDown);
            this.Controls.Add(this.scalingX_numericUpDown);
            this.Controls.Add(this.reflectionYX_button);
            this.Controls.Add(this.reflectionY_button);
            this.Controls.Add(this.reflectionX_button);
            this.Controls.Add(this.transferY_label);
            this.Controls.Add(this.transferY_numericUpDown);
            this.Controls.Add(this.restoration_button);
            this.Controls.Add(this.transferX_label);
            this.Controls.Add(this.transferX_numericUpDown);
            this.Controls.Add(this.draw_pictureBox);
            this.Name = "Transformations";
            this.Text = "Transformations";
            ((System.ComponentModel.ISupportInitialize)(this.draw_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferX_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferY_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingX_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingY_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationCentre_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPoint_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPointX_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPointY_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox draw_pictureBox;
        private System.Windows.Forms.NumericUpDown transferX_numericUpDown;
        private System.Windows.Forms.Label transferX_label;
        private System.Windows.Forms.Button restoration_button;
        private System.Windows.Forms.NumericUpDown transferY_numericUpDown;
        private System.Windows.Forms.Label transferY_label;
        private System.Windows.Forms.Button reflectionX_button;
        private System.Windows.Forms.Button reflectionY_button;
        private System.Windows.Forms.Button reflectionYX_button;
        private System.Windows.Forms.NumericUpDown scalingX_numericUpDown;
        private System.Windows.Forms.NumericUpDown scalingY_numericUpDown;
        private System.Windows.Forms.Label scalingX_label;
        private System.Windows.Forms.Label scalingY_label;
        private System.Windows.Forms.NumericUpDown rotationCentre_numericUpDown;
        private System.Windows.Forms.Label rotationCentre_button;
        private System.Windows.Forms.NumericUpDown rotationPoint_numericUpDown;
        private System.Windows.Forms.Label rotationPoint_label;
        private System.Windows.Forms.NumericUpDown rotationPointX_numericUpDown;
        private System.Windows.Forms.NumericUpDown rotationPointY_numericUpDown;
        private System.Windows.Forms.Label rotationPointX_label;
        private System.Windows.Forms.Label rotationPointY_label;
    }
}