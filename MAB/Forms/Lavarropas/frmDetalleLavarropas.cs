using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Models;
using MAB.Forms.Clientes;
using MAB.Forms.CRUD.Reparaciones;

namespace MAB.Forms.Lavarropas
{
    public partial class frmDetalleLavarropas : Form
    {
        public frmDetalleLavarropas(int idLavarropas)
        {
            InitializeComponent();

            cargarLavarropas(idLavarropas);

            ucBottom.Accion1 = "Modificar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += modificarLavarropas;
            ucBottom.evAccion2 += cerrarVentana;
        }

        Models.Lavarropas lavarropas;

        private void cargarLavarropas(int idLavarropas)
        {
            using(MABEntities db = new MABEntities())
            {
                lavarropas = db.Lavarropas.Find(idLavarropas);
            }

            cclblIdLavarropas.Text = lavarropas.Id.ToString();
            cclblMarcaLavarropas.Text = lavarropas.marca;
            cclblModeloLavarropas.Text = lavarropas.modelo;
            cclblEstadoGeneral.Text = lavarropas.estadoGeneral;

            Text = "Detalle del lavarropas " + lavarropas.marca + " " + lavarropas.modelo;
        }

        #region eventos ucBottom

        private void modificarLavarropas(object sender, EventArgs e)
        {
            frmModificarLavarropas frm = new frmModificarLavarropas(lavarropas.Id);
            frm.ShowDialog();

            cargarLavarropas(lavarropas.Id);
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region eventos de Botones

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            frmDetalleCliente frm = new frmDetalleCliente(lavarropas.ClienteId);
            frm.ShowDialog();
        }

        private void btnVerReparaciones_Click(object sender, EventArgs e)
        {
            frmReparaciones frm = new frmReparaciones(lavarropas.Id);
            frm.ShowDialog();

            cargarLavarropas(lavarropas.Id);
        }

        #endregion
    }
}
