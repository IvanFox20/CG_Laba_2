using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Laba_2
{
    internal class Star : Shape
    {
        public Star()  
        {
            _startPoints.Add(new List<float> { 0.00F, 0.00F, 1F });
            _startPoints.Add(new List<float> { 0.00F, 4.66F, 1F });
            _startPoints.Add(new List<float> { 1.00F, 2.00F, 1F });
            _startPoints.Add(new List<float> { 4.00F, 2.40F, 1F });
            _startPoints.Add(new List<float> { 2.24F, 0.00F, 1F });
            _startPoints.Add(new List<float> { 4.00F, -2.40F, 1F });
            _startPoints.Add(new List<float> { 1.00F, -2.00F, 1F });
            _startPoints.Add(new List<float> { 0.00F, -4.66F, 1F });
            _startPoints.Add(new List<float> { -1.0F, -2.00F, 1F });
            _startPoints.Add(new List<float> { -4.24F, -2.40F, 1F });
            _startPoints.Add(new List<float> { -2.00F, 0.00F, 1F });
            _startPoints.Add(new List<float> { -4.24F, 2.40F, 1F });
            _startPoints.Add(new List<float> { -1.00F, 2.00F, 1F });
            _currentPoints = new List<List<float>>(_startPoints.Select(sublist => new List<float>(sublist)));
        }
        public void Draw(Graphics g, Pen pen, float centreX, float centreY, float dx, float dy)
        {
            g.DrawLine(pen, centreX + _currentPoints[1][0] * dx, centreY + _currentPoints[1][1] * -dy, centreX + _currentPoints[2][0] * dx, centreY + _currentPoints[2][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[2][0] * dx, centreY + _currentPoints[2][1] * -dy, centreX + _currentPoints[3][0] * dx, centreY + _currentPoints[3][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[3][0] * dx, centreY + _currentPoints[3][1] * -dy, centreX + _currentPoints[4][0] * dx, centreY + _currentPoints[4][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[4][0] * dx, centreY + _currentPoints[4][1] * -dy, centreX + _currentPoints[5][0] * dx, centreY + _currentPoints[5][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[5][0] * dx, centreY + _currentPoints[5][1] * -dy, centreX + _currentPoints[6][0] * dx, centreY + _currentPoints[6][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[6][0] * dx, centreY + _currentPoints[6][1] * -dy, centreX + _currentPoints[7][0] * dx, centreY + _currentPoints[7][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[7][0] * dx, centreY + _currentPoints[7][1] * -dy, centreX + _currentPoints[8][0] * dx, centreY + _currentPoints[8][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[8][0] * dx, centreY + _currentPoints[8][1] * -dy, centreX + _currentPoints[9][0] * dx, centreY + _currentPoints[9][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[9][0] * dx, centreY + _currentPoints[9][1] * -dy, centreX + _currentPoints[10][0] * dx, centreY + _currentPoints[10][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[10][0] * dx, centreY + _currentPoints[10][1] * -dy, centreX + _currentPoints[11][0] * dx, centreY + _currentPoints[11][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[11][0] * dx, centreY + _currentPoints[11][1] * -dy, centreX + _currentPoints[12][0] * dx, centreY + _currentPoints[12][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[12][0] * dx, centreY + _currentPoints[12][1] * -dy, centreX + _currentPoints[1][0] * dx, centreY + _currentPoints[1][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[0][0] * dx, centreY + _currentPoints[0][1] * -dy, centreX + _currentPoints[2][0] * dx, centreY + _currentPoints[2][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[0][0] * dx, centreY + _currentPoints[0][1] * -dy, centreX + _currentPoints[4][0] * dx, centreY + _currentPoints[4][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[0][0] * dx, centreY + _currentPoints[0][1] * -dy, centreX + _currentPoints[6][0] * dx, centreY + _currentPoints[6][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[0][0] * dx, centreY + _currentPoints[0][1] * -dy, centreX + _currentPoints[8][0] * dx, centreY + _currentPoints[8][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[0][0] * dx, centreY + _currentPoints[0][1] * -dy, centreX + _currentPoints[10][0] * dx, centreY + _currentPoints[10][1] * -dy);
            g.DrawLine(pen, centreX + _currentPoints[0][0] * dx, centreY + _currentPoints[0][1] * -dy, centreX + _currentPoints[12][0] * dx, centreY + _currentPoints[12][1] * -dy);
        }
    }
}
