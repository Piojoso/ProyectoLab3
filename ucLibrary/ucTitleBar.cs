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

namespace ucLibrary
{
    public partial class ucTitleBar : UserControl
    {
        public ucTitleBar()
        {

            /**
             * TODO: selector de color de fondo
             * --- HECHO: en realidad solo acomode los colores del componente (hacerlos transparentes para que se vea el backcolor).
             * 
             * TODO: escribir titulo
             * --- HECHO
             * 
             * TODO: selector de iconos (Maximizar, Minimizar, Cerrar).
             * --- HECHO
             * 
             * TODO: Dar la chance de poder ocultar ciertos botones
             * --- HECHO
             * 
             * TODO: Selector de alineacion de Titulo (Izq, Der, Centro)
             * --- HECHO
             * 
             * TODO: Selector de alineacion de Botones (Izq, Der)
             * --- HECHO
             * 
             * TODO: opcion de agregar imagen de app.
             * 
             * TODO: color de fondo de botones, y color de texto de los botones.
             * 
             * TODO: color de texto del titulo
             * 
             * TODO: Agregar funcionabilidad a los botones
             * 
             * TODO: Agregar sistema de drag window
             * 
             * TODO: Agregar Click Derecho (Maximizar, Minimizar, Cerrar y si se me ocurre algo mas de 10)
             */

            InitializeComponent();
        }

        #region Titulo de la Ventana

        private string tituloVentana;

        public string TitleText
        {
            get { return tituloVentana; }
            set
            {
                tituloVentana = value;

                if (tituloVentana == string.Empty)
                    cclblTituloVentana.Text = "Window Title";
                else
                    cclblTituloVentana.Text = tituloVentana;
            }
        }

        #endregion

        #region Iconos de botones Max/Min/Close

        private IconChar iconMax;
        private IconChar iconMin;
        private IconChar iconClose;

        public IconChar IconMaximize
        {
            get { return iconMax; }
            set
            {
                iconMax = value;
                if (iconMax != IconChar.None)
                    iconBtnMaximizar.IconChar = iconMax;
                else
                    iconBtnMaximizar.IconChar = IconChar.WindowMaximize;
            }
        }

        public IconChar IconMinimize
        {
            get { return iconMin; }
            set
            {
                iconMin = value;
                if (iconMin != IconChar.None)
                    iconBtnMinimizar.IconChar = iconMin;
                else
                    iconBtnMinimizar.IconChar = IconChar.WindowMinimize;
            }
        }

        public IconChar IconClose
        {
            get { return iconClose; }
            set
            {
                iconClose = value;

                if (iconClose != IconChar.None)
                    iconBtnCerrar.IconChar = iconClose;
                else
                    iconBtnCerrar.IconChar = IconChar.TimesCircle;
            }
        }

        #endregion

        #region Posicion de Botones

        private Point primero = new Point(0, 0);
        private Point segundo = new Point(30, 0);
        private Point tercero = new Point(60, 0);

        #endregion

        #region Ocultar Maximizar/Minimizar

        private bool maximizeButton;

        private bool minimizeButton;

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

        #region Alineacion de Botones

        private DockStyle buttonsAlign;

        public DockStyle ButtonsAlign
        {
            get { return buttonsAlign; }
            set
            {
                if (buttonsAlign == DockStyle.None)
                {
                    buttonsAlign = DockStyle.Right;
                    ButtonsAlign = buttonsAlign;
                }
                else
                {
                    if ((value != DockStyle.Bottom) && (value != DockStyle.Top) && (value != DockStyle.Fill) && (value != DockStyle.None))
                    {
                        buttonsAlign = value;
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
        }

        private void acomodarBotones(Point Minimizar, Point Maximizar, Point Cerrar)
        {
            iconBtnMinimizar.Location = Minimizar;
            iconBtnMaximizar.Location = Maximizar;
            iconBtnCerrar.Location = Cerrar;
        }

        #endregion
    }
}
