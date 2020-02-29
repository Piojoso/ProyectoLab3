using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Forms.CRUD.Reparaciones;
using MAB.Forms.CRUD.Clientes;
using MAB.Forms;

namespace MAB
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucBG.Titulo = "MAB";

            ucBG.Accion1 = "Clientes";
            ucBG.Accion2 = "Reparaciones";
            ucBG.Accion3 = "Lavarropas";

            ucBG.evAccion1 += new EventHandler(btnClientes);
            ucBG.evAccion2 += new EventHandler(btnReparaciones);
            ucBG.evAccion3 += new EventHandler(btnLavarropas);
        }

        void btnClientes(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.ShowDialog();
        }

        void btnReparaciones(object sender, EventArgs e)
        {
            frmReparaciones frm = new frmReparaciones();
            frm.ShowDialog();
        }

        void btnLavarropas(object sender, EventArgs e)
        {
            /**
             * TODO: Crear formulario de CRUD de lavarropas
             */
            MessageBox.Show("Aun te falta este Formulario");
        }

        private void nuevoStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoFormStyle frm = new NuevoFormStyle();
            frm.ShowDialog();
        }
    }
}
