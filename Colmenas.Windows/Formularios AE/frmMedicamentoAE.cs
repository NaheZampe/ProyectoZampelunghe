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
    public partial class frmMedicamentoAE : Form
    {
        private Medicamentos medd;
        public frmMedicamentoAE()
        {
            InitializeComponent();
        }

        public Medicamentos GetMedicamento()
        {
            return medd;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (medd==null)
                {
                    medd = new Medicamentos();
                }
                medd.Medicamento=txtMedd.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var valido=true;
            if (string.IsNullOrEmpty(txtMedd.Text))
            {
                valido = false;
                errorProvider1.SetError(txtMedd, "¡¡¡Debe ingresar un nombre de Medicamento!!!");
            }
            return valido;
        }

        public void SetMedicamento(Medicamentos medd)
        {
            this.medd = medd;
        }

        private void frmMedicamentoAE_Load(object sender, EventArgs e)
        {
            if (medd!=null)
            {
                txtMedd.Text = medd.Medicamento;
            }
        }
    }
}
