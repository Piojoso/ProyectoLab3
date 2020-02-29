using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccLibrary;
using FontAwesome.Sharp;

namespace ucLibrary
{
    public partial class ucBotonera : UserControl
    {
        private ccButtom botonActual;
        private Panel pnlLeftBorderBtn;

        public ucBotonera()
        {
            InitializeComponent();

            pnlLeftBorderBtn = new Panel();
            pnlLeftBorderBtn.Size = new Size(5, 35);
            pnlBG.Controls.Add(pnlLeftBorderBtn);
        }

        #region Eventos

        //Campos
        public event EventHandler evClickAccion1;
        public event EventHandler evClickAccion2;
        public event EventHandler evClickAccion3;
        public event EventHandler evClickAccion4;
        public event EventHandler evClickAccion5;
        public event EventHandler evClickAccion6;
        public event EventHandler evClickAccion7;

        /**
         * TODO: Probar a ver si al seleccionar un numero de botones menores se puede hacer que dejen de ser accesible el resto. Posiblemente cambiandole la accesibilidad
         */
         
        //Funciones de eventos

        private void ccbtnAccion1_Click(object sender, EventArgs e)
        {
            evClickAccion1?.Invoke(sender, e);

            activarBoton(sender);
        }

        private void ccbtnAccion2_Click(object sender, EventArgs e)
        {
            evClickAccion2?.Invoke(sender, e);

            activarBoton(sender);
        }

        private void ccbtnAccion3_Click(object sender, EventArgs e)
        {
            evClickAccion3?.Invoke(sender, e);

            activarBoton(sender);
        }

        private void ccbtnAccion4_Click(object sender, EventArgs e)
        {
            evClickAccion4?.Invoke(sender, e);

            activarBoton(sender);
        }

        private void ccbtnAccion5_Click(object sender, EventArgs e)
        {
            evClickAccion5?.Invoke(sender, e);

            activarBoton(sender);
        }

        private void ccbtnAccion6_Click(object sender, EventArgs e)
        {
            evClickAccion6?.Invoke(sender, e);

            activarBoton(sender);
        }

        private void ccbtnAccion7_Click(object sender, EventArgs e)
        {
            evClickAccion7?.Invoke(sender, e);

            activarBoton(sender);
        }

        #endregion

        #region NumBotones

        private int numBotones;

        public int NumBotones
        {
            get { return numBotones; }
            set
            {
                numBotones = value;

                foreach(Control button in pnlBG.Controls)
                {
                    button.Visible = button.TabIndex > numBotones ? false : true;
                }
            }
        }

        #endregion

        #region Efecto de seleccionar Boton

        private Color colorAlternativo;
        
        public Color ColorAlternativo
        {
            get { return colorAlternativo; }
            set
            {
                colorAlternativo = value;
                
                pnlBG.Controls.OfType<ccButtom>().ToList().ForEach(btn =>
                {
                    btn.AlternativeBackColor = colorAlternativo;
                });
            }
        }

        private void activarBoton(object sender)
        {
            if(sender != null)
            {
                DesactivarActual();

                // Cambios al boton
                botonActual = (ccButtom)sender;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.alternateBackColor();

                // Cambios al panel
                pnlLeftBorderBtn.BackColor = Color.DodgerBlue;
                pnlLeftBorderBtn.Location = new Point(0, botonActual.Location.Y);
                pnlLeftBorderBtn.Visible = true;
                pnlLeftBorderBtn.BringToFront();
            }
        }

        private void DesactivarActual()
        {
            if(botonActual != null)
            {
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.alternateBackColor();
            }
        }

        #endregion

        #region Texto de Botones

        public string btnAccion1
        {
            get { return ccbtnAccion1.Text; }
            set { ccbtnAccion1.Text = value; }
        }
        public string btnAccion2
        {
            get { return ccbtnAccion2.Text; }
            set { ccbtnAccion2.Text = value; }
        }
        public string btnAccion3
        {
            get { return ccbtnAccion3.Text; }
            set { ccbtnAccion3.Text = value; }
        }
        public string btnAccion4
        {
            get { return ccbtnAccion4.Text; }
            set { ccbtnAccion4.Text = value; }
        }
        public string btnAccion5
        {
            get { return ccbtnAccion5.Text; }
            set { ccbtnAccion5.Text = value; }
        }
        public string btnAccion6
        {
            get { return ccbtnAccion6.Text; }
            set { ccbtnAccion6.Text = value; }
        }
        public string btnAccion7
        {
            get { return ccbtnAccion7.Text; }
            set { ccbtnAccion7.Text = value; }
        }

        #endregion
    }
}   
