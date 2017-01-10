using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struktury
{
    class PointArrayService
    {

        public void putOnePointToArray(ref Point3D[] points, TextBox X, TextBox Y, TextBox Z, Stopwatch stopwatch)
        {
            float x = float.Parse(X.Text);
            float y = float.Parse(Y.Text);
            float z = float.Parse(Z.Text);

            addPointToPointArray(ref points, x, y, z, stopwatch);
        }

        public void putMorePointToArray(ref Point3D[] points,TextBox NumberOfPoints, Stopwatch stopwatch)
        {
            Int64 n = Convert.ToInt64(NumberOfPoints.Text);

            Random random = new Random();

            float x = 0;
            float y = 0;
            float z = 0;


            for (int i = 0; i < n; i++)
            {
                x = random.Next(1, 21);
                y = random.Next(1, 21);
                z = random.Next(1, 21);
                addPointToPointArray(ref points, x, y, z, stopwatch);
            }
        }

        private void addPointToPointArray(ref Point3D[] points, float x, float y, float z, Stopwatch stopWatch)
        {
            Point3D point = new Struktury.Point3D(x, y, z);
            Array.Resize(ref points, points.Length + 1);

            stopWatch.Start();

            points[points.Length - 1] = point;

            stopWatch.Stop();
        }

        public void showPointArray(ref Point3D[] points, ListBox ArrayView, Label TitleLabel)
        {
            ArrayView.Items.Clear();
            TitleLabel.Text = "Tablica Struktur";
            foreach (Point3D point in points)
            {
                ArrayView.Items.Add(point.ToString());
            }
        }


    }
}
