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
    public partial class ccButtom : Label
    {
        private struct colors
        {
            public static Color colorPredefinido = Color.Transparent;
            public static Color colorAlternativo = Control.DefaultBackColor;
        }
        
        public ccButtom()
        {
            InitializeComponent();

            Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            BackColor = colors.colorPredefinido;
            Font = new Font("Microsoft Tai Le", 9.75F);
            Size = new Size(100, 35);
            MaximumSize = new Size(500, 35);
            TextAlign = ContentAlignment.MiddleCenter;
        }

        public void PerformClick()
        {
            OnClick(new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            AutoSize = false;
        }

        public Color AlternativeBackColor
        {
            get { return colors.colorAlternativo; }
            set { colors.colorAlternativo = value; }
        }

        public void alternateBackColor()
        {
            if (BackColor == colors.colorPredefinido)
                BackColor = colors.colorAlternativo;
            else
                BackColor = colors.colorPredefinido;
        }
    }
}
