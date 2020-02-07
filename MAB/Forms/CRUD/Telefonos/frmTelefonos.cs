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

namespace MAB.Forms.CRUD.Telefonos
{
    public partial class frmTelefonos : Form
    {
        Models.Clientes cliente;

        public frmTelefonos(int idCliente)
        {
            InitializeComponent();

            refrescarTelefonos(idCliente);
            
            ucBackGround.Titulo = "Telefonos del Cliente: " + cliente.nombre + " " + cliente.apellido;

            ucBackGround.numButtons(2);

            ucBackGround.Accion1 = "Agregar";
            ucBackGround.Accion3 = "Eliminar";

            ucBackGround.evAccion1 += agregarNuevo;
            ucBackGround.evAccion3 += eliminarSeleccionado;            
        }

        private void agregarNuevo(object sender, EventArgs e)
        {
            frmAgregarTelefono frm = new frmAgregarTelefono(cliente.Id);
            frm.ShowDialog();

            refrescarTelefonos(cliente.Id);
        }
        
        private void eliminarSeleccionado(object sender, EventArgs e)
        {
            //PROBAR LA OPCION DE NULL CUANDO NO HAY FILA SELECCIONADA

            DataGridViewRow fila =  ucBackGround.getSelectedItem();
            
            using (MABEntities db = new MABEntities())
            {
                var telefono = (from tel in db.Telefonos
                           where tel.telefono == Convert.ToInt64(fila.Cells["Telefono"].Value)
                           where tel.estado != false
                           select tel).First();

                DialogResult resp = MessageBox.Show(
                    "Esta a punto de eliminar el Telefono " + telefono.telefono + Environment.NewLine +
                    "del Cliente " + telefono.Cliente.nombre + " " + telefono.Cliente.apellido + Environment.NewLine +
                    "¿Quiere continuar con la eliminacion?", "Estas a Punto de eliminar un Telefono", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(resp == DialogResult.Yes)
                {
                    telefono.estado = false;

                    db.Entry(telefono).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
            }

            refrescarTelefonos(cliente.Id);
        } 
        
        private void refrescarTelefonos(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);

                var data = (from telefonos in db.Telefonos
                            where telefonos.ClienteId == cliente.Id
                            where telefonos.estado == true
                            select telefonos);

                ucBackGround.cargarDGV(data.ToList());
            }
        }
    }
}
