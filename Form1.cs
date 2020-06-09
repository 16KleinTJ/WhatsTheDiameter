using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsTheDiameter
{
    public partial class Form1 : Form
    {
        private List<Circle> circles;
        public Form1()
        {
            InitializeComponent();

            this.circles = new List<Circle>();
        }

        private void NewCircle_Click(object sender, EventArgs e)
        {
            try
            {
                var circle = new Circle(Convert.ToDouble(CircleInput.Text));
                this.circles.Add(circle);
                this.RedrawCircleCollection();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Input was not in the correct format");
            }
        }

        private void RedrawCircleCollection()
        {
            CircleCollection.Items.Clear();
            foreach (var circle in this.circles)
            {
                CircleCollection.Items.Add(circle.ToString());
            }
        }

        private void ShowArray_Click(object sender, EventArgs e)
        {
            string msg = "Radius         Diameter\n";
            msg +=       "---------------------------\n";
            foreach (var c in this.circles)
            {
                msg += String.Format("{0}                        {1}\n", c.getRadius(), c.getDiameter());
            }
            MessageBox.Show(msg); // use a monospaced font to centre text
        }

        private void SetRadius_Click(object sender, EventArgs e)
        {
            try
            {
                double newRadius = Convert.ToDouble(CircleInput.Text);
                var c = circles[CircleCollection.SelectedIndex]; // grabs currently highlighted circle
                c.setRadius(newRadius);
                this.RedrawCircleCollection();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("The radius was not in the correct\nformat or a cicle was not selected");
            }
            catch
            {
            }
        }

        private void CircleCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try // stops it from crashing when the area around the circle is selected
            {
                var c = circles[CircleCollection.SelectedIndex];
                circleData.Text = String.Format("Radius: {0}\nDiameter: {1}\nArea: {2}\nCircumference: {3}", c.getRadius(), c.getDiameter(), c.getArea(), c.getCircumference());
            }
            catch
            {
            }
        }
    }
}
