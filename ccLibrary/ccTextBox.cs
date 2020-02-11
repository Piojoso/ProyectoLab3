using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccLibrary
{
    public partial class ccTextBox : TextBox
    {
        public ccTextBox()
        {
            InitializeComponent();

            Anchor = AnchorStyles.None;
            Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            Size = new System.Drawing.Size(231, 20);
        }
    }
}
