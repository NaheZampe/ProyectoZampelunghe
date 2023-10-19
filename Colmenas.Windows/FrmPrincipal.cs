using Colmenas.Entidades;
using Colmenas.Servicios;
using Colmenas.Servicios.Interfaces;
using Colmenas.Servicios.Servicios;
using Colmenas.Windows.Formularios_AE;
using Colmenas.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Colmenas.Windows
{
    public partial class FrmPrincipal : Form
    {
        //Provincias
        private readonly IServicioProvincia _servicioProvincia;
        private List<Provincia> listaProv;
        //Alimentos
        private readonly IServicioAlimentos _servicioAlimentos;
        private List<Alimentos> listaAlim;
        //Medicamentos
        private readonly IServicioMedicamentos _servicioMedicamentos;
        private List<Medicamentos> listaMed;
        //Categorias
        private readonly IServicioCategoria _servicioCategoria;
        private List<Categoria> listaCateg;

        public FrmPrincipal()
        {
            InitializeComponent();
            _servicioProvincia = new ServicioProvincia();
            _servicioAlimentos = new ServicioAlimentos();
            _servicioMedicamentos= new ServicioMedicamentos();
            _servicioCategoria=new ServicioCategoria();
        }

        //Provincias
        //Ver Listado
        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            GridHelper.BorrarGrilla(dgvDatos);
            GridHelper.LimpiarGrilla(dgvDatos);
            GridHelper.CargarGrillaProvincia(dgvDatos);
            RefrescarGrillaProvincia();
        }
        private void RefrescarGrillaProvincia()
        {
            listaProv = _servicioProvincia.GetProvincias();
            GridHelper.MostrarDatosEnGrilla(dgvDatos, listaProv);
        }

        //Agregar
        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvAE frm = new frmProvAE() { Text = "Agregar provincia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var prov = frm.GetProvincia();
                if (!_servicioProvincia.Existe(prov))
                {
                    _servicioProvincia.Guardar(prov);
                    RecargarGrillaProvincias(prov);
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RecargarGrillaProvincias(Provincia prov)
        {
            DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
            GridHelper.SetearFila(r, prov);
            GridHelper.AgregarFila(dgvDatos, r);
            RefrescarGrillaProvincia();
        }

        //Editar
        private void ProvinciaEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un elemento", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag.GetType() != typeof(Provincia))
            {
                return;
            }
            Provincia provincia = (Provincia)r.Tag;
            Provincia provinciaCopia = (Provincia)provincia.Clone();

            try
            {
                frmProvAE frm = new frmProvAE() { Text = "Editar Provincia" };
                frm.SetProvincia(provincia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                provincia = frm.GetProvincia();
                if (!_servicioProvincia.Existe(provincia))
                {
                    _servicioProvincia.Guardar(provincia);
                    GridHelper.SetearFila(r, provincia);
                    RefrescarGrillaProvincia();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelper.SetearFila(r, provinciaCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, provinciaCopia);
                MessageBox.Show(ex.Message, "Error!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Borrar
        private void BorrarProvincia_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un elemento", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag.GetType() != typeof(Provincia))
            {
                return;
            }
            Provincia provincia = (Provincia)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicioProvincia.Borrar(provincia.IdProvincia);
                GridHelper.QuitarFila(dgvDatos, r);
                RefrescarGrillaProvincia();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        //Alimentos

        //Ver Listado
        private void VerAlimentos_Click(object sender, EventArgs e)
        {
            GridHelper.BorrarGrilla(dgvDatos);
            GridHelper.LimpiarGrilla(dgvDatos);
            GridHelper.CargarGrillaAlimentos(dgvDatos);
            RefrescarGrillaAlimentos();
        }
        private void RefrescarGrillaAlimentos()
        {
            listaAlim = _servicioAlimentos.GetAlimentos();
            GridHelper.MostrarDatosEnGrilla(dgvDatos, listaAlim);
        }

        //Agregar
        private void AgregarAlimento_Click(object sender, EventArgs e)
        {
            frmAlimentosAE frm = new frmAlimentosAE() { Text = "Agregar Alimento" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var alim = frm.GetAlimento();
                if (!_servicioAlimentos.Existe(alim))
                {
                    _servicioAlimentos.Guardar(alim);
                    RecargarGrillaAlimentos(alim);
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RecargarGrillaAlimentos(Alimentos alim)
        {
            DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
            GridHelper.SetearFila(r, alim);
            GridHelper.AgregarFila(dgvDatos, r);
            RefrescarGrillaAlimentos();
        }

        //Borrar
        private void BorrarAlimento_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un elemento", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag.GetType() != typeof(Alimentos))
            {
                return;
            }
            Alimentos alimentos = (Alimentos)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicioAlimentos.Borrar(alimentos.IdAlimento);
                GridHelper.QuitarFila(dgvDatos, r);
                RefrescarGrillaAlimentos();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Editar
        private void EditarAlimento_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un elemento", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if(r.Tag.GetType() != typeof(Alimentos))
            {
                return;
            }
            Alimentos alimento = (Alimentos)r.Tag;
            Alimentos alimentoCopia = (Alimentos)alimento.Clone();

            try
            {
                frmAlimentosAE frm = new frmAlimentosAE() { Text = "Editar Alimento" };
                frm.SetAlimento(alimento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                alimento = frm.GetAlimento();
                if (!_servicioAlimentos.Existe(alimento))
                {
                    _servicioAlimentos.Guardar(alimento);
                    GridHelper.SetearFila(r, alimento);
                    RefrescarGrillaAlimentos();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelper.SetearFila(r, alimentoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, alimentoCopia);
                MessageBox.Show(ex.Message, "Error!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        //Medicamentos
        //Ver Listado
        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridHelper.BorrarGrilla(dgvDatos);
            GridHelper.LimpiarGrilla(dgvDatos);
            GridHelper.CargarGrillaMedicamentos(dgvDatos);
            RefrescarGrillaMedicamentos();
        }
        private void RefrescarGrillaMedicamentos()
        {
            listaMed = _servicioMedicamentos.GetMedicamentos();
            GridHelper.MostrarDatosEnGrilla(dgvDatos, listaMed);
        }
        //Agregar
        private void AgregarMedicamento_Click(object sender, EventArgs e)
        {
            frmMedicamentoAE frm = new frmMedicamentoAE() { Text = "Agregar Medicamento" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var medd = frm.GetMedicamento();
                if (!_servicioMedicamentos.Existe(medd))
                {
                    _servicioMedicamentos.Guardar(medd);
                    RecargarGrillaMedicamentos(medd);
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RecargarGrillaMedicamentos(Medicamentos medd)
        {
            DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
            GridHelper.SetearFila(r, medd);
            GridHelper.AgregarFila(dgvDatos, r);
            RefrescarGrillaMedicamentos();
        }

        //Borrar
        private void BorrarMedicamento_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un elemento","Atención",
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag.GetType() != typeof(Medicamentos))
            {
                return;
            }
            Medicamentos medd = (Medicamentos)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                _servicioMedicamentos.Borrar(medd.IdMedicamento);
                GridHelper.QuitarFila(dgvDatos, r);
                RefrescarGrillaMedicamentos();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "¡¡Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Editar
        private void EditarMedd_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar un elemento", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag.GetType() != typeof(Medicamentos))
            {
                return;
            }
            Medicamentos medd = (Medicamentos)r.Tag;
            Medicamentos meddCopia = (Medicamentos)medd.Clone();

            try
            {
                frmMedicamentoAE frm = new frmMedicamentoAE() { Text = "Editar Medicamento" };
                frm.SetMedicamento(medd);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                medd = frm.GetMedicamento();
                if (!_servicioMedicamentos.Existe(medd))
                {
                    _servicioMedicamentos.Guardar(medd);
                    GridHelper.SetearFila(r, medd);
                    RefrescarGrillaMedicamentos();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelper.SetearFila(r, meddCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, meddCopia);
                MessageBox.Show(ex.Message, "Error!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        //Categorias
        //Ver Listado
        private void VerCategorias_Click(object sender, EventArgs e)
        {
            GridHelper.BorrarGrilla(dgvDatos);
            GridHelper.LimpiarGrilla(dgvDatos);
            GridHelper.CargarGrillaCategoria(dgvDatos);
            RefrescarGrillaCategoria();
        }
        private void RefrescarGrillaCategoria()
        {
            listaCateg = _servicioCategoria.GetCategoria();
            GridHelper.MostrarDatosEnGrilla(dgvDatos, listaCateg);
        }

        //Agregar
        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
            frmMedicamentoAE frm = new frmMedicamentoAE() { Text = "Agregar Medicamento" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var medd = frm.GetMedicamento();
                if (!_servicioMedicamentos.Existe(medd))
                {
                    _servicioMedicamentos.Guardar(medd);
                    RecargarGrillaMedicamentos(medd);
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
