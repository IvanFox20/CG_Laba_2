﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Laba_2
{
    internal class Circle : Shape
    {
        public Circle(float x, float y)
        {
            _startPoints.Add(new List<float> { x, y, 1F });
            _currentPoints = new List<List<float>>(_startPoints.Select(sublist => new List<float>(sublist)));
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red) , _currentPoints[0][0], _currentPoints[0][1],30,30);
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
