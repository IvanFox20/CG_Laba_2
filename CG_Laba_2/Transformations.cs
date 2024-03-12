using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CG_Laba_2
{
    public partial class Transformations : Form
    {
        private Graphics g;
        private Star star = new Star();
        public Transformations()
        {
            InitializeComponent();
            g = draw_pictureBox.CreateGraphics();
        }

        private void DrawShape()
        {
            Pen pen = new Pen(Color.Black, 3);
            float width = draw_pictureBox.Width;
            float height = draw_pictureBox.Height;
            float centreX = width / 2;
            float centreY = height / 2;
            float dx = width / 30;
            float dy = height / 30;
            DrawAxis(width, height, centreX, centreY, dx, dy);
            star.Draw(g, pen, centreX, centreY, dx, dy);
        }

        private void DrawAxis(float width, float height, float centreX, float centreY, float dx, float dy)
        {
            g.DrawLine(Pens.Black, centreX, 0, centreX, height);
            g.DrawLine(Pens.Black, 0, centreY, width, centreY);
            Font Fon = new Font("Arial", 9, FontStyle.Regular);
            Brush Br = Brushes.Black;
            g.DrawString("X", Fon, Br, width - 15, centreY + 10);
            g.DrawString("Y", Fon, Br, centreX - 20, 10);
            Font Fon1 = new Font("Arial", 6, FontStyle.Regular);
            for (int i = -15; i < 15; i++)
            {
                g.DrawString(i.ToString(), Fon1, Br, centreX - 15, centreY + dy * -i);
                g.DrawString(i.ToString(), Fon1, Br, centreX + dx * i - 10, centreY + 10);
            }
        }

        private void restoration_button_Click(object sender, EventArgs e)
        {
            star.Restoration();
            InterfaceValuesRefresh();
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private void InterfaceValuesRefresh()
        {
            transferX_numericUpDown.Value = 0.0m;
            transferY_numericUpDown.Value = 0.0m;
            scalingX_numericUpDown.Value = 1.00m;
            scalingY_numericUpDown.Value = 1.00m;
            rotationCentre_numericUpDown.Value = 0;
            rotationPointX_numericUpDown.Value = 0;
            rotationPointY_numericUpDown.Value = 0;
            rotationPoint_numericUpDown.Value = 0;
            Invalidate();
        }

        private float transferXPreviousValue = 0;
        private float transferXValue = 0;
        private void transferX_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)transferX_numericUpDown.Value - transferXPreviousValue - 0.1F) < 0.001)
            {
                transferXValue = 0.1F;
            }
            else if (Math.Abs((float)transferX_numericUpDown.Value - transferXPreviousValue + 0.1F) < 0.001)
            {
                transferXValue = -0.1F;
            }
            else
            {
                transferXValue = (float)transferX_numericUpDown.Value;
            }
            transferXPreviousValue = (float)transferX_numericUpDown.Value;
            star.TransferX(transferXValue);
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private float transferYPreviousValue = 0;
        private float transferYValue = 0;
        private void transferY_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)transferY_numericUpDown.Value - transferYPreviousValue - 0.1F) < 0.001)
            {
                transferYValue = 0.1F;
            }
            else if (Math.Abs((float)transferY_numericUpDown.Value - transferYPreviousValue + 0.1F) < 0.001)
            {
                transferYValue = -0.1F;
            }
            else
            {
                transferYValue = (float)transferY_numericUpDown.Value;
            }
            transferYPreviousValue = (float)transferY_numericUpDown.Value;
            star.TransferY(transferYValue);
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private void reflectionX_button_Click(object sender, EventArgs e)
        {
            star.ReflectionX();
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private void reflectionY_button_Click(object sender, EventArgs e)
        {
            star.ReflectionY();
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private void reflectionYX_button_Click(object sender, EventArgs e)
        {
            star.ReflectionYX();
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private float scalingXPreviousValue = 0;
        private float scalingXValue = 1;
        private void scalingX_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)scalingX_numericUpDown.Value - scalingXPreviousValue - 0.05F) < 0.001)
            {
                scalingXValue = 1.05F;
            }
            else if (Math.Abs((float)scalingX_numericUpDown.Value - scalingXPreviousValue + 0.05F) < 0.001)
            {
                scalingXValue = 0.95F;
            }
            else
            {
                scalingXValue = (float)scalingX_numericUpDown.Value;
            }
            scalingXPreviousValue = (float)scalingX_numericUpDown.Value;
            star.ScalingX(scalingXValue);
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        private float scalingYPreviousValue = 0;
        private float scalingYValue = 1;
        private void scalingY_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)scalingY_numericUpDown.Value - scalingYPreviousValue - 0.05F) < 0.001)
            {
                scalingYValue = 1.05F;
            }
            else if (Math.Abs((float)scalingY_numericUpDown.Value - scalingYPreviousValue + 0.05F) < 0.001)
            {
                scalingYValue = 0.95F;
            }
            else
            {
                scalingYValue = (float)scalingY_numericUpDown.Value;
            }
            scalingYPreviousValue = (float)scalingY_numericUpDown.Value;
            star.ScalingY(scalingYValue);
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        double angleCentre = 0;
        double previousAngleCentre = 0;
        private void rotationCentre_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)rotationCentre_numericUpDown.Value - previousAngleCentre - 1) < 0.001)
            {
                angleCentre = 1D;
            }
            else if (Math.Abs((float)rotationCentre_numericUpDown.Value - previousAngleCentre + 1) < 0.001)
            {
                angleCentre = -1D;
            }
            else
            {
                angleCentre = (float)rotationCentre_numericUpDown.Value;
            }
            previousAngleCentre = (float)rotationCentre_numericUpDown.Value;
            star.RotationCentre(angleCentre);
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }

        float rotationPointX = 0;
        float rotationPointY = 0;
        private void rotationPointX_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            rotationPointX = (float)rotationPointX_numericUpDown.Value;
        }

        private void rotationPointY_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            rotationPointY = (float)rotationPointY_numericUpDown.Value;
        }

        double anglePoint = 0;
        double previousAnglePoint = 0;
        private void rotationPoint_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Abs((float)rotationPoint_numericUpDown.Value - previousAnglePoint - 1) < 0.001)
            {
                anglePoint = 1D;
            }
            else if (Math.Abs((float)rotationPoint_numericUpDown.Value - previousAnglePoint + 1) < 0.001)
            {
                anglePoint = -1D;
            }
            else
            {
                anglePoint = (float)rotationPoint_numericUpDown.Value;
            }
            previousAnglePoint = (float)rotationPoint_numericUpDown.Value;
            star.RotationPoint(anglePoint,rotationPointX,rotationPointY);
            g.Clear(draw_pictureBox.BackColor);
            DrawShape();
        }
    }
}