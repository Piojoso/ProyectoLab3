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
    public partial class ccLabel : Label
    {
        public ccLabel()
        {
            InitializeComponent();

            Anchor = System.Windows.Forms.AnchorStyles.None;
            AutoSize = true;
            Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            Name = "lblEtiqueta";
            Size = new System.Drawing.Size(100, 23);
        }

        /*
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        */
    }
}
