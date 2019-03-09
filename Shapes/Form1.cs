using System;
using System.Drawing;
using System.Windows.Forms;

//simple program to illustrate OOP concepts in C#
// ** encapsulation
// ** inheritance
// ** polymorphism
// ** abstraction

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string r = "na";

            //todo:  add error checking for numbers

            switch (listShapes.SelectedItem)
            { 
                case "Circle":
                    r = new Circle(double.Parse(txtCircRadius.Text)).Area().ToString();
                    break;
                case "Rectangle":
                    r = new Rectangle(double.Parse(txtRecW.Text), double.Parse(txtRecH.Text)).Area().ToString();
                    break;
                default:
                    break;
            }

            lblArea.Text = r;
        }

        private void listShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show or hide the correct groupbox

            //set to the blank box
            GroupBox selected = grpDefault;

            switch (listShapes.SelectedItem)
            {
                case "Circle":
                    selected = grpCircle;
                    break;
                case "Rectangle":
                    selected = grpRectangle;
                    break;
                default:
                    //no shape selected, show the blank parameters box
                    break;

            }

            //move the selected groupbox to it's positon
            selected.Location = new Point(10, 125);
            selected.BringToFront();
        }
    }
}
