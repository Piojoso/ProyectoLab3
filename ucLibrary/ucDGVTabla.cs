﻿using System;
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
    public partial class ucDGVTabla : UserControl
    {
        public ucDGVTabla()
        {
            /**
             * TODO: Hacer un selector de iconos, Sinceramente creiria que no se van a cambiar, por mas que sea tampoco hay muchas opciones
             * --- HECHO
             * 
             * TODO: See All no abrira un formulario, sera un boton que alternara el listado en el DGV
             * --- HECHO
             * 
             * TODO: Al clickear Minus, se enseñara la "lista corta", y el boton cambiara a Bars, al clickearlo enseñara la lista completa
             * --- HECHO: Aunque cambio algo, ahora no se cambia el boton, sino que muestra que se esta lista, si la lista corta (minus)
             *              o la lista larga (bars)
             * 
             * TODO: ofrecer metodos get para devolver todos los contactos encontrados.
             * --- HECHO: en realidad no, pero es innecesario, el creador del frm que se abre tiene una referencia al objeto, asique puede
             *              obtener los resultados desde ahi.
             * 
             * TODO: Evento click del boton seeAll
             * --- HECHO EN EL COMMIT ANTERIOR, olvide anotarlo.
             * 
             * TODO: Permitir cargar un contextMenuStrip al DGV para que este aparezca al hacer click derecho sobre el componente
             * --- HECHO
             */
            InitializeComponent();

            dgvPrincipal.CellDoubleClick += dobleClickSobreItemDGV;
        }

        #region Eventos de cerrado de formularios

        public event EventHandler ModificacionFinalizada;

        private void frmModifyClose(object sender, EventArgs e)
        {
            ModificacionFinalizada?.Invoke(sender, e);

        }

        public event EventHandler BusquedaFinalizada;

        private void frmSearchClose(object sender, EventArgs e)
        {
            BusquedaFinalizada?.Invoke(sender, e);

        }

        #endregion

        #region Evento de DobleClik sobre una item en el DGV

        public event EventHandler CellDoubleClick;
        
        private void dobleClickSobreItemDGV(object sender, EventArgs e)
        {
            CellDoubleClick?.Invoke(sender, e);

        }
        
        #endregion

        #region Colors of Button

        private Color fondoBotones;

        public Color FondoBotones
        {
            get { return fondoBotones; }
            set
            {
                fondoBotones = value;

                if (!fondoBotones.IsEmpty)
                {
                    foreach (IconButton btn in gbButtons.Controls)
                    {
                        btn.BackColor = fondoBotones;
                    }
                }
                else
                {
                    btnAdd.BackColor = colorsButtons.btnAdd;
                    btnModify.BackColor = colorsButtons.btnModify;
                    btnSeeAll.BackColor = colorsButtons.btnSeeAll;
                    btnSearch.BackColor = colorsButtons.btnSearch;
                    btnDelete.BackColor = colorsButtons.btnDelete;
                }
            }
        }

        private struct colorsButtons
        {
            public static Color btnAdd = Color.ForestGreen;
            public static Color btnModify = Color.FromArgb(192, 192, 0);
            public static Color btnSeeAll = Color.DarkGray;
            public static Color btnSearch = Color.SteelBlue;
            public static Color btnDelete = Color.IndianRed;
        }

        public Color buttonAdd
        {
            get { return colorsButtons.btnAdd; }
            set { colorsButtons.btnAdd = value; }
        }

        public Color buttonModify
        {
            get { return colorsButtons.btnModify; }
            set { colorsButtons.btnModify = value; }
        }

        public Color buttonSeeAll
        {
            get { return colorsButtons.btnSeeAll; }
            set { colorsButtons.btnSeeAll = value; }
        }

        public Color buttonSearch
        {
            get { return colorsButtons.btnSearch; }
            set { colorsButtons.btnSearch = value; }
        }

        public Color buttonDelete
        {
            get { return colorsButtons.btnDelete; }
            set { colorsButtons.btnDelete = value; }
        }

        #endregion

        #region DGVStyle

        private DataGridViewCellStyle columnHeaders;
        private DataGridViewCellStyle rowsHeaders;
        private DataGridViewCellStyle rowsCells;

        public DataGridViewCellStyle ColumnHeaderStyle
        {
            get { return columnHeaders; }
            set
            {
                columnHeaders = value;

                if (columnHeaders != null)
                    dgvPrincipal.ColumnHeadersDefaultCellStyle = columnHeaders;
            }
        }

        public DataGridViewCellStyle RowsHeaderStyle
        {
            get { return rowsHeaders; }
            set
            {
                rowsHeaders = value;

                if (columnHeaders != null)
                    dgvPrincipal.RowHeadersDefaultCellStyle = rowsHeaders;
            }
        }

        public DataGridViewCellStyle RowsCellStyle
        {
            get { return rowsCells; }
            set
            {
                rowsCells = value;

                if (columnHeaders != null)
                    dgvPrincipal.DefaultCellStyle = rowsCells;
            }
        }

        #endregion

        #region Botones y sus Forms

        private struct forms
        {
            public static Form frmAdd;
            public static Form frmModify;
            public static Form frmSearch;
            public static Form frmDelete;
        }

        public Form FrmAdd
        {
            get { return forms.frmAdd; }
            set { forms.frmAdd = value; }
        }

        public Form FrmModify
        {
            get { return forms.frmModify; }
            set
            {
                forms.frmModify = value;

                if (forms.frmModify != null)
                    forms.frmModify.FormClosed += frmModifyClose;
            }
        }

        public Form FrmSearch
        {
            get { return forms.frmSearch; }
            set
            {
                forms.frmSearch = value;

                if (forms.frmSearch != null)
                    forms.frmSearch.FormClosed += frmSearchClose;
            }
        }

        public Form FrmDelete
        {
            get { return forms.frmDelete; }
            set { forms.frmDelete = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            forms.frmAdd?.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            forms.frmModify?.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            forms.frmSearch?.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            forms.frmDelete?.ShowDialog();
        }

        #endregion

        public void dataSource(object data, bool shortList = true)
        {
            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = data;
            this.columns = dgvPrincipal.Columns;

            if (!shortList)
            {
                all = data;

                btnSeeAll.IconChar = IconBtnSeeAll;
            }
            else
            {
                this.shortList = data;

                btnSeeAll.IconChar = IconBtnSeeShort;
            }
            
        }

        #region DGVColumns

        private DataGridViewColumnCollection columns;

        public DataGridViewColumnCollection Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        #endregion

        #region Delete Button

        private bool deleteVisibility = true;

        [DefaultValue(true)]
        public bool DeleteVisibility
        {
            get { return deleteVisibility; }
            set
            {
                deleteVisibility = value;

                btnDelete.Visible = deleteVisibility;
            }
        }

        #endregion

        public DataGridViewRow selectedRow()
        {
            return dgvPrincipal.Rows[dgvPrincipal.CurrentRow.Index];
        }

        #region Iconos de Botones

        private IconChar iconBtnAdd = IconChar.Plus;
        private IconChar iconBtnModify = IconChar.Edit;
        private IconChar iconBtnSeeAll = IconChar.Bars;
        private IconChar iconBtnSeeShort = IconChar.Minus;
        private IconChar iconBtnSearh = IconChar.Search;
        private IconChar iconBtnDelete = IconChar.Trash;

        [DefaultValue(IconChar.Plus)]
        public IconChar IconBtnAdd
        {
            get { return IconBtnAdd; }
            set
            {
                iconBtnAdd = value;

                btnAdd.IconChar = iconBtnAdd;
            }
        }

        [DefaultValue(IconChar.Edit)]
        public IconChar IconBtnModify
        {
            get { return iconBtnModify; }
            set
            {
                iconBtnModify = value;

                btnModify.IconChar = iconBtnModify;
            }
        }

        [DefaultValue(IconChar.Bars)]
        public IconChar IconBtnSeeAll
        {
            get { return iconBtnSeeAll; }
            set
            {
                iconBtnSeeAll = value;

                if (!cargadoShortList)
                {
                    btnSeeAll.IconChar = iconBtnSeeAll;
                }
            }
        }

        [DefaultValue(IconChar.Minus)]
        public IconChar IconBtnSeeShort
        {
            get { return iconBtnSeeShort; }
            set
            {
                iconBtnSeeShort = value;

                if (cargadoShortList)
                    btnSeeAll.IconChar = iconBtnSeeShort;
            }
        }

        [DefaultValue(IconChar.Search)]
        public IconChar IconBtnSearch
        {
            get { return iconBtnSearh; }
            set
            {
                iconBtnSearh = value;

                btnSearch.IconChar = iconBtnSearh;
            }
        }

        [DefaultValue(IconChar.Trash)]
        public IconChar IconBtnDelete
        {
            get { return iconBtnDelete; }
            set
            {
                iconBtnDelete = value;

                btnDelete.IconChar = iconBtnDelete;
            }
        }

        #endregion

        #region btnSeeAll
        
        private object all;
        private object shortList;

        public object FullListData
        {
            get { return all; }
            set { all = value; }
        }

        public object ShortListData
        {
            get { return shortList; }
            set { shortList = value; }
        }

        private bool cargadoShortList = true;

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            alternarDatosDGV();
        }

        private void alternarDatosDGV()
        {
            if(all != null && shortList != null)
            {
                if (cargadoShortList)
                {
                    dataSource(all);
                    btnSeeAll.IconChar = IconBtnSeeAll;
                    cargadoShortList = false;
                }
                else
                {
                    dataSource(shortList);
                    btnSeeAll.IconChar = IconBtnSeeShort;
                    cargadoShortList = true;
                }
            }
        }

        #endregion

        #region ContextMenuStrip (cms) para el DGV

        private ContextMenuStrip cms;

        public ContextMenuStrip cargarCMS
        {
            get { return cms; }
            set
            {
                cms = value;
                dgvPrincipal.ContextMenuStrip = cms;
            }
        }

        #endregion
    }
}
