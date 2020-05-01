using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ccLibrary;
using System.Runtime.InteropServices;
using MAB.Forms.CRUD.Clientes;
using MAB.Forms.CRUD.Lavarropas;
using MAB.Forms.CRUD.Reparaciones;
using MAB.Models;

namespace MAB.Forms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            /**
             * TODO: Analizar la posibilidad de colocar un mini reloj con la hora actual. ¿para que?: nose, solo por hacerlo.
             * No solo eso, Esta sera la ventana de inicio del proyecto y desde aca tengo pensado que se podrian llegar a enseñar ciertas
             * estadisticas. Como cantidad de Lavarropas ingresados del ultimo mes, Cantidad de Lavarropas finalizados, Suma recaudada, etc.
             * Alertas sobre Stock Faltante, Quizas la opcion de Filtrar informacion de alguna manera. Nose como aun.
             * 
             * TODO: Capturar posible error de la DB para enseñarlo si es oportuno, o realizar un segundo intento, si se puede
             * --- Cancelado
             * 
             * TODO: Hacer que la barra superior, de control de la ventana, sea un User Control separado. Para reutilizar
             * --- HECHO
             * 
             * TODO: Todos los formularios que agregan y modifican no dan feedback. Hay que decir "GG" si se guardo correctamente.
             * 
             * TODO: Todos los formularios que agregan no preguntan si se desea agregar uno nuevamente.
             */

            InitializeComponent();

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
            ucBotonera.NumBotones = 5;                              
            ucBotonera.ColorAlternativo = Control.DefaultBackColor;

            ucBotonera.btnAccion1 = "Inicio";
            ucBotonera.btnAccion2 = "Clientes";
            ucBotonera.btnAccion3 = "Reparaciones";
            ucBotonera.btnAccion4 = "Lavarropas";
            ucBotonera.btnAccion5 = "Stock";

            ucBotonera.evClickAccion1 += verInicio;                                                        
            ucBotonera.evClickAccion2 += verClientes;
            ucBotonera.evClickAccion3 += verReparaciones;
            ucBotonera.evClickAccion4 += verLavarropas;
            ucBotonera.evClickAccion5 += verStock;

            ucBotonera.BotonInicial = 1;
        }

        #region Acciones Botones

        private void verInicio(object sender, EventArgs e)
        {
            if (hijoActual != null)
                hijoActual.Close();
        }

        private void verClientes(object sender, EventArgs e)
        {
            abrirFormulario(new frmClientes());
        }

        private void verReparaciones(object sender, EventArgs e)
        {
            abrirFormulario(new frmReparaciones());
        }

        private void verLavarropas(object sender, EventArgs e)
        {
            abrirFormulario(new frmLavarropas());
        }

        private void verStock(object sender, EventArgs e)
        {
            /**
             * TODO: Asignar su correspondiente formulario a este Boton
             */
            //abrirFormulario();
        }

        #endregion
        
        #region Formulario Hijo

        //Campos
        private Form hijoActual;

        private void abrirFormulario(Form hijo)
        {
            if(hijoActual != null)
            {
                hijoActual.Close();
            }
            hijoActual = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(hijo);
            pnlContent.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();

            ucTitleBar.TitleText = "MAB - " + hijo.Text;
        }

        #endregion
    }
}
