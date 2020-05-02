using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Forms.CRUD.Clientes;
using MAB.Models;

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmAgregarReparaciones : Form
    {
        public frmAgregarReparaciones(int idLavarropas)
        {
            /**
             * TODO: Revisar su correcto funcionamiento.
             */

            InitializeComponent();

            cargarLavarropas(idLavarropas);
            
            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += agregarReparacion;
            ucBottom.evAccion2 += cerrarVentana;
        }

        private Models.Lavarropas lavarropas;

        private void cargarLavarropas(int idLavarropas)
        {
            using (MABEntities db = new MABEntities())
            {
                lavarropas = db.Lavarropas.Find(idLavarropas);
            }

            Text = "Agregar nueva Reparacion al lavarropas: " + lavarropas.marca + " " + lavarropas.modelo;

            cclblNombreCliente.Text = lavarropas.Cliente.nombre + " " + lavarropas.Cliente.apellido;
            cclblMarcaLavarropas.Text = lavarropas.marca + " " + lavarropas.modelo;
        }

        private void agregarReparacion(object sender, EventArgs e)
        {
            if((cctbErrorAReparar.Text != string.Empty) && (dtpFechaIngreso.Value <= DateTime.Now))
            {
                DialogResult resp = MessageBox.Show(
                    "Se guardara una nueva reparacion \n" +
                    "para el lavarropas " + lavarropas.marca + " " + lavarropas.modelo + "\n" +
                    "del cliente " + lavarropas.Cliente.nombre + " " + lavarropas.Cliente.apellido + "\n" +
                    "con el siguiente error a reparar: \n" +
                    cctbErrorAReparar.Text + "\n" +
                    "y con la siguiente fecha de ingreso: " + dtpFechaIngreso.Value.ToLongDateString() + "\n" +
                    "¿Desea continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(resp == DialogResult.Yes)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        Models.Reparaciones reparacion = new Models.Reparaciones();

                        reparacion.fechaIngreso = dtpFechaIngreso.Value;
                        reparacion.fechaEgreso = null;
                        reparacion.errorAReparar = cctbErrorAReparar.Text;
                        reparacion.estadoReparacion = estadosReparacion.EnCurso;
                        reparacion.mesesGarantia = null;
                        reparacion.reparacionRealizada = "";
                        reparacion.manoDeObra = 0;
                        reparacion.totalRepuestos = 0;
                        reparacion.LavarropasId = lavarropas.Id;

                        db.Reparaciones.Add(reparacion);

                        MessageBox.Show("Reparacion agregada correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay campos que faltan completar o la fecha es incorrecta \n" +
                    "Por favor revise la informacion y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
