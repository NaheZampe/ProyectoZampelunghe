using Colmenas.Entidades;
using Colmenas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmenas.Windows
{
    public partial class frmProvAE : Form
    {
        private Provincia prov;
        public frmProvAE()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
        public Provincia GetProvincia()
        {
            return prov;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (prov == null)
                {
                    prov = new Provincia();
                }
                
                prov.NombreProvincia=txtProv.Text;
                DialogResult= DialogResult.OK;
                
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtProv.Text))
            {
                valido = false;
                errorProvider1.SetError(txtProv, "¡¡¡Debe ingresar un nombre de Provincia!!!");

            }
            return valido;
        }
        public void SetProvincia(Provincia prov)
        {
            this.prov = prov;
        }

        private void frmProvAE_Load(object sender, EventArgs e)
        {
            if (prov != null)
            {
                txtProv.Text = prov.NombreProvincia;
            }
        }
    }
}
