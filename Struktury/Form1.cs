using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Struktury
{
    public partial class Form1 : Form
    {
        private bool isObjectArray = false;
        private bool isPointArray = true;

        private bool ifAddOnePoint = true;
        private bool ifAddMorePoint = false;

        long time = 0;
        Stopwatch stopWatch = new Stopwatch();

        private Point3D[] points = new Point3D[0];
        private Object[] pointsObject = new Object[0];

        private PointArrayService pointArrayService = new PointArrayService();
        private ObjectArrayService objectArrayService = new ObjectArrayService();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayPointArrayButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#67E300");
            ClearPointArrayButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#67E300");

            DisplayObjectArrayButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#8EF13C");
            ClearObjectArrayButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#8EF13C");

            AddButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#A9F16C");
            ClearArrayView.BackColor = System.Drawing.ColorTranslator.FromHtml("#A9F16C");
        }


        private void OnePointRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OnePointRadioButton.Checked)
            {
                
                ifAddOnePoint = true;
                ifAddMorePoint = false;
            }  
        }

        private void MorePointRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MorePointRadioButton.Checked)
            {
                ifAddOnePoint = false;
                ifAddMorePoint = true;
            }
        }

        private void PointArrayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PointArrayRadioButton.Checked)
            {
                isObjectArray = false;
                isPointArray = true;
            }
        }

        private void ObjectArrayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjectArrayRadioButton.Checked)
            {
                isObjectArray = true;
                isPointArray = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            time = 0;
            addPointToArray();
            time = stopWatch.Elapsed.Ticks * 100;
            stopWatch.Reset();
            SaveTime.Text = time.ToString() + " ns";
        }

        private void addPointToArray()
        {
            if (isPointArray && ifAddOnePoint)
            {
                pointArrayService.putOnePointToArray(ref points, XValueEdit, YValueEdit, ZValueEdit, stopWatch);
                //putOnePointToPointArray();    
            }

            else if (isPointArray && ifAddMorePoint)
            {
                pointArrayService.putMorePointToArray(ref points, NumberOfPointsEdit, stopWatch);
                //putMorePointToPointArray();
            }

            else if (isObjectArray && ifAddOnePoint)
            {
                objectArrayService.putOnePointToObjectArray(ref pointsObject, XValueEdit, YValueEdit, ZValueEdit, stopWatch);
               // putOnePointToObjectArray();   
            }

            else if  (isObjectArray && ifAddMorePoint)
            {
                objectArrayService.putMorePointToObjectArray(ref pointsObject, NumberOfPointsEdit, stopWatch);
               // putMorePointToObjectArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objectArrayService.showObjectArray(ref pointsObject, ArrayView, TitleLabel);
            //showObjectArray();
        }

        private void DisplayPointArrayButton_Click(object sender, EventArgs e)
        {
            pointArrayService.showPointArray(ref points, ArrayView, TitleLabel);
            //showPointArray();
        }

        private void ClearPointArrayButton_Click(object sender, EventArgs e)
        {
            points = new Point3D[0];   
        }

        private void ClearObjectArrayButton_Click(object sender, EventArgs e)
        {
            pointsObject = new Object[0];
        }

        private void ClearArrayView_Click(object sender, EventArgs e)
        {
            ArrayView.Items.Clear();
        }
    }
}
