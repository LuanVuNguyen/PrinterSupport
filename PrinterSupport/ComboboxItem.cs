using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterSupport
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public Color ForeColor { get; set; }
        public Font Font { get; set; }
        public bool Checked { get; set; }
        public Icon icon { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
