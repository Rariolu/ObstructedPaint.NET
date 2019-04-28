using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintByAPI
{
    public static class Fncs
    {
        public static Bitmap EmptyImage(Size imagesize)
        {
            Bitmap bmp = new Bitmap(imagesize.Width, imagesize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            return bmp;
        }
        public static string GetString(this Point point)
        {
            return string.Format("({0},{1})", point.X, point.Y);
        }
        public static string GetString(this Color colour)
        {
            return string.Format("({0},{1},{2})", colour.R, colour.G, colour.B);
        }
    }
}