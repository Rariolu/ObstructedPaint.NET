using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colour = System.Drawing.Color;

namespace PaintByAPI
{
    public class PaintBox : PictureBox
    {
        public PaintBox()
        {
            BackColor = Colour.White;
        }
        bool penDown = false;
        public bool PenDown
        {
            get
            {
                return penDown;
            }
            set
            {
                penDown = value;
            }
        }
        Point mousePosition = new Point();
        public Point PenPosition
        {
            get
            {
                return mousePosition;
            }
            set
            {
                mousePosition = value;
            }
        }
        Colour penColour = Colour.Black;
        public Colour PenColour
        {
            get
            {
                return penColour;
            }
            set
            {
                penColour = value;
            }
        }
        float penWidth = 1;
        public float PenWidth
        {
            get
            {
                return penWidth;
            }
            set
            {
                penWidth = value;
            }
        }
        Pen pen
        {
            get
            {
                return new Pen(PenColour, PenWidth);
            }
        }
        public void MoveMouse(Point newPos)
        {
            if (PenDown)
            {
                Image = Image ?? Fncs.EmptyImage(Size);
                using (Graphics g = Graphics.FromImage(Image))
                {
                    g.DrawLine(pen, mousePosition, newPos);
                }
            }
            mousePosition = newPos;
        }
    }
}