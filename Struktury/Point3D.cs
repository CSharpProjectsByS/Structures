using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    struct Point3D
    {
        public float x { get; }
        public float y { get; }
        public float z { get; }

        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;    
        }

 

        public override string ToString()
        {
            String points = "Punkt x: ";
            points += Convert.ToString(x);
            points += ", y: ";
            points += Convert.ToString(y);
            points += ", x: ";
            points += Convert.ToString(z);

            return points;
        }
    }
}
