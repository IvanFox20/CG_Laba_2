using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Laba_2.Shapes
{
    internal class Rect : Shape
    {
        public Rect(float x, float y)
        {
            _startPoints.Add(new List<float> { x, y, 1F });
            _currentPoints = new List<List<float>>(_startPoints.Select(sublist => new List<float>(sublist)));
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), _currentPoints[0][0], _currentPoints[0][1], 30, 120);
        }

        public float GetX()
        {
            return _currentPoints[0][0];
        }
        public float GetY()
        {
            return _currentPoints[0][1];
        }
    }
}
