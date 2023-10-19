using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmenas.Windows.Formularios_AE
{
    public partial class frmAlimentosAE : Form
    {
        private Alimentos alimentos;
        public frmAlimentosAE()
        {
            InitializeComponent();
        }


        public Alimentos GetAlimento()
        {
            return alimentos;
        }
        public void SetAlimento(Alimentos alimentos)
        {
            this.alimentos = alimentos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (alimentos == null)
                {
                    alimentos = new Alimentos();
                }

                alimentos.Alimento = txtAlim.Text;
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtAlim.Text))
            {
                valido = false;
                errorProvider1.SetError(txtAlim, "¡¡¡Debe ingresar un nombre de Alimento!!!");

            }
            return valido;
        }

        private void frmAlimentosAE_Load(object sender, EventArgs e)
        {
            if (alimentos!=null)
            {
                txtAlim.Text = alimentos.Alimento;
            }
        }
    }
}
