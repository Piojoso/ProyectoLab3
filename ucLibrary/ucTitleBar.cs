using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace ucLibrary
{
    public partial class ucTitleBar : UserControl
    {
        public ucTitleBar()
        {
            InitializeComponent();
        }

        private Form buscarFormulario(Control objeto)
        {
            if (objeto is Form)
                return (objeto as Form);
            else
                return buscarFormulario(objeto.Parent);
        }

        #region Titulo de la Ventana

        private string tituloVentana = "Window Title";

        [DefaultValue("Window Title")]
        public string TitleText
        {
            get { return tituloVentana; }
            set
            {
                tituloVentana = value;

                cclblTituloVentana.Text = tituloVentana;
            }
        }

        #endregion

        #region Iconos de botones Max/Min/Close

        private IconChar iconMax = IconChar.WindowMaximize;
        private IconChar iconNormal = IconChar.WindowRestore;
        private IconChar iconMin = IconChar.WindowMinimize;
        private IconChar iconClose = IconChar.TimesCircle;

        [DefaultValue(IconChar.WindowMaximize)]
        public IconChar IconMaximize
        {
            get { return iconMax; }
            set
            {
                if (iconMax != IconChar.None)
                    iconMax = value;
                else
                    iconMax = IconChar.WindowMaximize;

                iconBtnMaximizar.IconChar = iconMax;
            }
        }

        [DefaultValue(IconChar.WindowRestore)]
        public IconChar IconNormal
        {
            get { return iconNormal; }
            set
            {
                if (iconNormal != IconChar.None)
                    iconNormal = value;
                else
                    iconNormal = IconChar.WindowRestore;
            }
        }

        [DefaultValue(IconChar.WindowMinimize)]
        public IconChar IconMinimize
        {
            get { return iconMin; }
            set
            {
                if (iconMin != IconChar.None)
                    iconMin = value;
                else
                    iconMin = IconChar.WindowMinimize;

                iconBtnMinimizar.IconChar = iconMin;
            }
        }

        [DefaultValue(IconChar.TimesCircle)]
        public IconChar IconClose
        {
            get { return iconClose; }
            set
            {
                if (iconClose != IconChar.None)
                    iconClose = value;
                else
                    iconClose = IconChar.TimesCircle;

                iconBtnCerrar.IconChar = iconClose;
            }
        }

        #endregion

        #region Posicion de Botones

        private Point primero = new Point(0, 0);
        private Point segundo = new Point(30, 0);
        private Point tercero = new Point(60, 0);

        #endregion
        
        #region Alineacion de Titulo

        private ContentAlignment textAlign;
        
        public ContentAlignment TitleAlign
        {
            get { return textAlign; }
            set
            {
                textAlign = value;

                if (cclblTituloVentana.AutoSize != false)
                    cclblTituloVentana.AutoSize = false;

                cclblTituloVentana.TextAlign = textAlign;
            }
        }

        #endregion

        #region Ocultar Maximizar/Minimizar

        private bool maximizeButton = true;

        private bool minimizeButton = true;

        [DefaultValue(true)]
        public bool MaximizeBox
        {
            get { return maximizeButton; }
            set
            {
                maximizeButton = value;

                iconBtnMaximizar.Visible = maximizeButton;

                if (pnlBotones.Dock == DockStyle.Right)
                {
                    if (iconBtnMaximizar.Visible == false)
                        acomodarBotones(Maximizar: primero, Minimizar: segundo, Cerrar: tercero);
                    else
                        acomodarBotones(Minimizar: primero, Maximizar: segundo, Cerrar: tercero);
                }

            }
        }

        [DefaultValue(true)]
        public bool MinimizeBox
        {
            get { return minimizeButton; }
            set
            {
                minimizeButton = value;
                iconBtnMinimizar.Visible = minimizeButton;

                if(pnlBotones.Dock == DockStyle.Left)
                {
                    if (iconBtnMinimizar.Visible == false)
                        acomodarBotones(Cerrar: primero, Maximizar: segundo, Minimizar: tercero);
                    else
                        acomodarBotones(Cerrar: primero, Minimizar: segundo, Maximizar: tercero);
                }
            }
        }

        #endregion

        private void acomodarBotones(Point Minimizar, Point Maximizar, Point Cerrar)
        {
            iconBtnMinimizar.Location = Minimizar;
            iconBtnMaximizar.Location = Maximizar;
            iconBtnCerrar.Location = Cerrar;
        }
        
        #region Alineacion de Botones

        private DockStyle buttonsAlign = DockStyle.Right;

        [DefaultValue(DockStyle.Right)]
        public DockStyle ButtonsAlign
        {
            get { return buttonsAlign; }
            set
            {
                buttonsAlign = value;

                if (buttonsAlign != DockStyle.Bottom && buttonsAlign != DockStyle.Top && buttonsAlign != DockStyle.Fill && buttonsAlign != DockStyle.None)
                {
                    pnlBotones.Dock = buttonsAlign;

                    if (pnlBotones.Dock == DockStyle.Right)
                        acomodarBotones(Minimizar: primero, Maximizar: segundo, Cerrar: tercero);
                    else
                        acomodarBotones(Cerrar: primero, Minimizar: segundo, Maximizar: tercero);
                }
                else
                    MessageBox.Show("Propiedad Invalida " + Environment.NewLine + 
                        "Solo se permiten Right o Left", "Propiedad Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Back y Fore Color de Botones

        private Color buttonsBackColor;

        private Color buttonsForeColor;
        
        public Color ButtonsBackColor
        {
            get { return buttonsBackColor; }
            set
            {
                buttonsBackColor = value;

                if (buttonsBackColor.IsEmpty)
                    backColorBTN(BackColor);
                else
                    backColorBTN(buttonsBackColor);
            }
        }

        public Color ButtonsForeColor
        {
            get { return buttonsForeColor; }
            set
            {
                buttonsForeColor = value;

                if (buttonsForeColor.IsEmpty)
                    foreColorBTN(DefaultForeColor);
                else
                    foreColorBTN(buttonsForeColor);
                    
            }
        }

        private void backColorBTN(Color color)
        {
            iconBtnMinimizar.BackColor = color;
            iconBtnMaximizar.BackColor = color;
            iconBtnCerrar.BackColor = color;
        }

        private void foreColorBTN(Color color)
        {
            iconBtnMinimizar.IconColor = color;
            iconBtnMaximizar.IconColor = color;
            iconBtnCerrar.IconColor = color;
        }

        #endregion

        #region Font del Titulo

        [DisplayName("Title Font")]
        public override Font Font
        {
            get { return cclblTituloVentana.Font; }
            set { cclblTituloVentana.Font = value; }
        }

        #endregion

        #region Funcion de los botones

        private void Minimizar_Click(object sender, EventArgs e)
        {
            Form frm = buscarFormulario(this);

            frm.WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            Form frm = buscarFormulario(this);

            if (frm.WindowState == FormWindowState.Maximized)
            {
                frm.WindowState = FormWindowState.Normal;
                iconBtnMaximizar.IconChar = iconMax;

                cmsiRestaurar.Enabled = false;
                cmsiMaximizar.Enabled = true;
            }
            else
            {
                frm.WindowState = FormWindowState.Maximized;
                iconBtnMaximizar.IconChar = iconNormal;

                cmsiRestaurar.Enabled = true;
                cmsiMaximizar.Enabled = false;
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Form frm = buscarFormulario(this);

            frm.Close();
        }
        
        #endregion
        
        #region Arrastrar ventana

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = buscarFormulario(this);

            ReleaseCapture();
            SendMessage(frm.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
