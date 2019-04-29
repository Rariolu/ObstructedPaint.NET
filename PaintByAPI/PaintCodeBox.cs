using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintByAPI
{
    public class PaintCodeBox : TextBox
    {
        string prev = "0, 0, 0, 0";
        public PaintCodeBox()
        {
            Text = "0, 0, 0, 0";
            TextChanged += PaintCodeBox_TextChanged;
        }
        private void PaintCodeBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}