﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Models;

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmBuscarReparacion : Form
    {
        public frmBuscarReparacion()
        {
            /**
             * TODO: Comprobar el correcto funcionamiento
             */

            InitializeComponent();
            
            ucBottom.Accion1 = "Buscar";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += buscarReparacion;
            ucBottom.evAccion3 += cerrarVentana;
        }

        private List<int> idResultados;

        public List<int> getResultados
        {
            get { return idResultados; }
        }

        private void buscarReparacion(object sender, EventArgs e)
        {
            if (dtpInicioIngreso.Value < DateTime.Now)
                dtpInicioIngreso.Value = DateTime.Now;

            if (dtpFinIngreso.Value < DateTime.Now)
                dtpFinIngreso.Value = DateTime.Now;

            if (dtpInicioEgreso.Value < DateTime.Now)
                dtpInicioEgreso.Value = DateTime.Now;

            if (dtpFinEgreso.Value < DateTime.Now)
                dtpFinEgreso.Value = DateTime.Now;
            
            using (MABEntities db = new MABEntities())
            {
                List<Models.Reparaciones> reparaciones = db.Reparaciones.ToList();

                foreach(Models.Reparaciones reparacion in reparaciones)
                {
                    if((reparacion.fechaIngreso >= dtpInicioIngreso.Value) && (reparacion.fechaIngreso <= dtpFinIngreso.Value))
                    {
                        idResultados.Add(reparacion.Id);
                        break;
                    }
                    else if ((reparacion.fechaEgreso >= dtpInicioEgreso.Value) && (reparacion.fechaEgreso <= dtpFinEgreso.Value))
                    {
                        idResultados.Add(reparacion.Id);
                        break;
                    }
                }
            }

            if(idResultados.Count != 0)
            {
                DialogResult resp = MessageBox.Show("Se encontraron " + idResultados.Count + " Resultados. \n" +
                    "¿Desea verlos?", "¿Ver Resultados?", MessageBoxButtons.YesNo);

                if( resp == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron reparaciones en esos rangos de Fechas. Pruebe con otros", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
