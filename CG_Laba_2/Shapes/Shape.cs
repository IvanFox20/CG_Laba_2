using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Laba_2
{
    internal class Shape
    {
        protected List<List<float>> _startPoints = new List<List<float>>();
        protected List<List<float>> _currentPoints = new List<List<float>>();

        protected List<List<float>> MatrixMultiplication(List<List<float>> matrixA, List<List<float>> matrixB)
        {
            int rowsA = matrixA.Count();
            int colsA = matrixA[0].Count();
            int rowsB = matrixB.Count();
            int colsB = matrixB[0].Count();

            List<List<float>> resultMatrix = new List<List<float>>();

            for (int i = 0; i < rowsA; i++)
            {
                resultMatrix.Add(new List<float>());
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i].Add(0);
                }
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    float sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA[i][k] * matrixB[k][j];
                    }
                    resultMatrix[i][j] = sum;
                }
            }
            return resultMatrix;
        }


        public void TransferX(float value)
        {
            foreach (var point in _currentPoints)
            {
                point[0] += value;
            }
        }
        public void TransferY(float value)
        {
            foreach (var point in _currentPoints)
            {
                point[1] += value;
            }
        }

        public void ReflectionX()
        {
            foreach (var point in _currentPoints)
            {
                point[1] = -point[1];
            }
        }
        public void ReflectionY()
        {
            foreach (var point in _currentPoints)
            {
                point[0] = -point[0];
            }
        }
        public void ReflectionYX()
        {
            float temp;
            foreach (var point in _currentPoints)
            {
                temp = point[0];
                point[0] = point[1];
                point[1] = temp;
            }
        }
        public void Restoration()
        {
            _currentPoints = new List<List<float>>(_startPoints.Select(sublist => new List<float>(sublist)));
        }

        public void ScalingX(float value)
        {
            foreach (var point in _currentPoints)
            {
                point[0] *= value;
            }
        }
        public void ScalingY(float value)
        {
            foreach (var point in _currentPoints)
            {
                point[1] *= value;
            }
        }

        public void RotationCentre(double angle)
        {
            double radianAngle = angle * Math.PI / 180;
            List<List<float>> transformationMatrix = new List<List<float>>();
            transformationMatrix.Add(new List<float> { (float)Math.Cos(radianAngle), (float)Math.Sin(radianAngle) });
            transformationMatrix.Add(new List<float> { -(float)Math.Sin(radianAngle), (float)Math.Cos(radianAngle) });
            for (int i = 0; i < _currentPoints.Count; i++)
            {
                List<List<float>> pointMatrix = new List<List<float>>
                {
                    new List<float> { _currentPoints[i][0] },
                    new List<float> { _currentPoints[i][1] }
                };
                List<List<float>> rotatedPointMatrix = MatrixMultiplication(transformationMatrix, pointMatrix);
                _currentPoints[i][0] = rotatedPointMatrix[0][0];
                _currentPoints[i][1] = rotatedPointMatrix[1][0];
            }
        }
        public void RotationPoint(double angle, float x, float y)
        {
            double radianAngle = angle * Math.PI / 180;
            List<List<float>> transformationMatrix = new List<List<float>>();
            transformationMatrix.Add(new List<float> { (float)Math.Cos(radianAngle), (float)Math.Sin(radianAngle), x * (1 - (float)Math.Cos(radianAngle)) - y * (float)Math.Sin(radianAngle) });
            transformationMatrix.Add(new List<float> { -(float)Math.Sin(radianAngle), (float)Math.Cos(radianAngle), y * (1 - (float)Math.Cos(radianAngle)) + x * (float)Math.Sin(radianAngle) });
            transformationMatrix.Add(new List<float> { 0F, 0F, 1F });
            for (int i = 0; i < _currentPoints.Count; i++)
            {
                List<List<float>> pointMatrix = new List<List<float>>
        {
            new List<float> { _currentPoints[i][0] },
            new List<float> { _currentPoints[i][1] },
            new List<float> { 1F } // Добавляем 1 в качестве третьей координаты точки
        };
                List<List<float>> rotatedPointMatrix = MatrixMultiplication(transformationMatrix, pointMatrix);
                _currentPoints[i][0] = rotatedPointMatrix[0][0];
                _currentPoints[i][1] = rotatedPointMatrix[1][0];
            }
        }

    }
}
