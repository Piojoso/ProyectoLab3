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

namespace MAB.Forms.CRUD.Clientes
{
    public partial class frmBuscarCliente : Form
    {
        public List<int> idClientes;

        public frmBuscarCliente()
        {
            /**
             * TODO: Revisar el correcto Funcionamiento
             */

            InitializeComponent();

            Text = "Buscar Cliente";
            
            ucBottom.Accion1 = "Buscar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += buscarCliente;
            ucBottom.evAccion2 += cerrarBusqueda;

            string messageError = "Solo se permiten Letras, no se permiten numeros.";

            cctbNombre.CaracterIncorrectErrorMessage = messageError;
            cctbApellido.CaracterIncorrectErrorMessage = messageError;
        }
        
        private void buscarCliente(object sender, EventArgs e)
        {
            idClientes = buscar();

            if (idClientes.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "No hubo resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cctbNombre.Focus();
            }
        }

        private List<int> buscar()
        {
            List<int> resp = new List<int>();

            bool nombre = cctbNombre.Text != string.Empty ? true : false;
            bool apellido = cctbApellido.Text != string.Empty ? true : false;
            bool direccion = cctbDireccion.Text != string.Empty ? true : false;

            using (MABEntities db = new MABEntities())
            {
                var clientes = db.Clientes;

                foreach (Models.Clientes cliente in clientes)
                {
                    if (nombre && cctbNombre.Text == cliente.nombre)
                    {
                        resp.Add(cliente.Id);
                        break;
                    }
                    else if (apellido && cctbApellido.Text == cliente.apellido)
                    {
                        resp.Add(cliente.Id);
                        break;
                    }
                    else if (direccion && cctbDireccion.Text == cliente.direccion)
                    {
                        resp.Add(cliente.Id);
                        break;
                    }
                }
            }

            return resp;
        }

        private void cerrarBusqueda(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
