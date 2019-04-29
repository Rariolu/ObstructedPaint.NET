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
        public void MoveMouse(int x, int y)
        {
            MoveMouse(new Point(x, y));
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
        public void AcceptCode(params int[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case 0:
                    {
                        PenDown = !PenDown;
                        break;
                    }
                    case 1:
                    {
                        if (args.Length > 1)
                        {
                            int width = args[1];
                            if (width > 0 && width <= 100)
                            {
                                PenWidth = width;
                            }
                        }
                        break;
                    }
                    case 2:
                    {
                        if (args.Length > 2)
                        {
                            int x = args[1];
                            int y = args[2];
                            MoveMouse(x, y);
                        }
                        break;
                    }
                    case 3:
                    {
                        if (args.Length > 3)
                        {
                            Func<int,bool> inColourRange = (num) =>
                            {
                                return num >= 0 && num <= 255;
                            };
                            int r = args[1];
                            int g = args[2];
                            int b = args[3];
                            if (inColourRange(r) && inColourRange(g) && inColourRange(b))
                            {
                                PenColour = Colour.FromArgb(r, g, b);
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}