using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucLibrary
{
    public partial class ucTop : UserControl
    {
        public ucTop()
        {
            InitializeComponent();
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; lblTitulo.Text = titulo; }
        }
    }
}
