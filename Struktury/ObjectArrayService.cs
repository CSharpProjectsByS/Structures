using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struktury
{
    class ObjectArrayService
    {

        public void putOnePointToObjectArray(ref Object[] points, TextBox X, TextBox Y, TextBox Z, Stopwatch stopwatch)
        {
            float x = float.Parse(X.Text);
            float y = float.Parse(Y.Text);
            float z = float.Parse(Z.Text);

            addPointToObjectArray(ref points, x, y, z, stopwatch);
        }

        public void putMorePointToObjectArray(ref Object[] points, TextBox NumberOfPoints, Stopwatch stopwatch)
        {
            Int64 n = Convert.ToInt64(NumberOfPoints.Text);

            float x = 0;
            float y = 0;
            float z = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                x = random.Next(1, 21);
                y = random.Next(1, 21);
                z = random.Next(1, 21);
                addPointToObjectArray(ref points,x, y, z, stopwatch);
            }
        }

        private void addPointToObjectArray(ref Object[] pointObjects,float x, float y, float z, Stopwatch stopwatch)
        {
            Object point = new Struktury.Point3D(x, y, z);
            Array.Resize(ref pointObjects, pointObjects.Length + 1);

            stopwatch.Start();

            pointObjects[pointObjects.Length - 1] = point;

            stopwatch.Stop();
        }

        public void showObjectArray(ref Object[] points, ListBox ArrayView, Label TitleLabel)
        {
            ArrayView.Items.Clear();
            TitleLabel.Text = "Tablica Obiektów";
            /*foreach (Object point in points)
            {
                ArrayView.Items.Add(point.ToString());
            }*/

            ArrayView.Items.AddRange(points);
        }

    }
}
