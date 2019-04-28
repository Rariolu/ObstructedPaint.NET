using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintByAPI
{
    public partial class MainForm : Form
    {
        const int increment = 10;
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnPen_Click(object sender, EventArgs e)
        {
            pbCanvas.PenDown = !pbCanvas.PenDown;
            lblPenState.Text = pbCanvas.PenDown ? "Pen Down" : "Pen Up";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Point newPos = new Point(pbCanvas.PenPosition.X, pbCanvas.PenPosition.Y - increment);
            MovePen(newPos);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            Point newPos = new Point(pbCanvas.PenPosition.X, pbCanvas.PenPosition.Y + increment);
            MovePen(newPos);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            Point newPos = new Point(pbCanvas.PenPosition.X - increment, pbCanvas.PenPosition.Y);
            MovePen(newPos);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            Point newPos = new Point(pbCanvas.PenPosition.X + increment, pbCanvas.PenPosition.Y);
            MovePen(newPos);
        }
        void MovePen(Point newPos)
        {
            pbCanvas.MoveMouse(newPos);
            lblPenPosition.Text = pbCanvas.PenPosition.GetString();
        }
        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pbCanvas.PenColour = cd.Color;
                lblColour.Text = cd.Color.GetString();
            }
        }
        private void nupPenSize_ValueChanged(object sender, EventArgs e)
        {
            pbCanvas.PenWidth = (int)nupPenSize.Value;
        }
    }
}