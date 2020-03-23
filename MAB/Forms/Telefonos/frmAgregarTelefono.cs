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
    public partial class frmAgregarTelefono : Form
    {

        Models.Clientes cliente;

        public frmAgregarTelefono(int idCliente)
        {
            InitializeComponent();


            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);

                cclblIdCliente.Text = idCliente.ToString();
            }

            ucTop.Titulo = "Agregar Telefono a " + cliente.nombre + " " + cliente.apellido;

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion3 = "Cancelar";

            ucBottom.evAccion1 += agregarTelefono;
            ucBottom.evAccion3 += cancelar;
        }

        private void agregarTelefono(object sender, EventArgs e)
        {
            /**
             * TODO: Tengo que agregarle un control, para que si el telefono ya existe, no agregarlo de nuevo, solamente cambiarle el estado.
             * NOTA: El telefono se deberia de estar queriendo agregar al mismo cliente, Ya que en ese caso, si volviera a agregarlo se repetirian claves. Malo Malo.
             */

            if(tbTelefono.Text != string.Empty)
            {
                using (MABEntities db = new MABEntities())
                {
                    Models.Telefonos telefono = new Models.Telefonos();

                    telefono.ClienteId = cliente.Id;
                    telefono.telefono = Convert.ToInt64(tbTelefono.Text);
                    telefono.estado = true;

                    db.Telefonos.Add(telefono);
                    db.SaveChanges();
                }
            }
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
