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


namespace MAB.Forms
{
    public partial class NuevoFormStyle : Form
    {
        public NuevoFormStyle()
        {

            /**
             * TODO: Analizar la posibilidad de colocar en el titulo de la ventana el estado de la conexion con la DB = {Conectada, Conectando, No Conectada};
             * 
             * TODO: Analizar la posibilidad de colocar un mini reloj con la hora actual. ¿para que?: nose, solo por hacerlo.
             */
            InitializeComponent();

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
            ucBotonera.NumBotones = 4;                              
            ucBotonera.ColorAlternativo = Control.DefaultBackColor;

            ucBotonera.btnAccion1 = "Clientes";
            ucBotonera.btnAccion2 = "Reparaciones";
            ucBotonera.btnAccion3 = "Lavarropas";
            ucBotonera.btnAccion4 = "Stock";
                                                                    
            ucBotonera.evClickAccion1 += verClientes;
            ucBotonera.evClickAccion2 += verReparaciones;
            ucBotonera.evClickAccion3 += verLavarropas;
            ucBotonera.evClickAccion4 += verStock;

        }

        #region Acciones Botones

        private void verClientes(object sender, EventArgs e)
        {
            abrirFormulario(new frmClientes());
        }

        private void verReparaciones(object sender, EventArgs e)
        {
            /**
             * TODO: Asignar el Formulario a este Boton
             */
            //abrirFormulario();
        }

        private void verLavarropas(object sender, EventArgs e)
        {
            /**
             * TODO: Asignar su correspondiende formulario a este Boton
             */
            //abrirFormulario();
        }

        private void verStock(object sender, EventArgs e)
        {
            /**
             * TODO: Asignar su correspondiente formulario a este Boton
             */
            //abrirFormulario();
        }

        #endregion

        #region Mover Ventana

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Maximizar, Minimizar, Cerrar Ventana

        private void iconBtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconBtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            cclblTituloVentana.Text = "MAB - " + hijo.Text;
        }

        #endregion
    }
}
