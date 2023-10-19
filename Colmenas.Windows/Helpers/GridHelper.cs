using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Colmenas.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Provincia provincia:
                    r.Cells[0].Value = provincia.NombreProvincia;
                    break;
                case Alimentos alimento:
                    r.Cells[0].Value = alimento.Alimento;
                    break;
                case Medicamentos medicamento:
                    r.Cells[0].Value = medicamento.Medicamento;
                    break;
                case Categoria categoria:
                    r.Cells[0].Value = categoria.NombreCategoria;
                    r.Cells[1].Value = categoria.Descripcion;
                    break;
            }
            r.Tag = obj;

        }
        public static void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Remove(r);
        }

        public static void BorrarGrilla(DataGridView dgv)
        {
            dgv.Columns.Clear();
        }
        public static void MostrarDatosEnGrilla<T>(DataGridView dgv, List<T> lista) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var obj in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgv);
                SetearFila(r, obj);
                AgregarFila(dgv, r);
            }

        }
        public static void CargarGrillaProvincia(DataGridView dgvDatos)
        {
            var columna = new DataGridViewTextBoxColumn();
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.Name = "Columna Provincia";
            columna.HeaderText = "Provincia";
            dgvDatos.Columns.Add(columna);
        }
        public static void CargarGrillaAlimentos(DataGridView dgvDatos)
        {
            var columna = new DataGridViewTextBoxColumn();
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.Name = "Columna Alimentos";
            columna.HeaderText = "Alimentos";
            dgvDatos.Columns.Add(columna);
        }
        public static void CargarGrillaMedicamentos(DataGridView dgvDatos)
        {
            var columna = new DataGridViewTextBoxColumn();
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.Name = "Columna Medicamentos";
            columna.HeaderText = "Medicamentos";
            dgvDatos.Columns.Add(columna);
        }

        public static void CargarGrillaCategoria(DataGridView dgvDatos)
        {
            //Columna Categoria
            var columna = new DataGridViewTextBoxColumn();
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.Name = "Columna Categoria";
            columna.HeaderText = "Categoria";
            dgvDatos.Columns.Add(columna);
            //Columna Descripcion
            var columna2 = new DataGridViewTextBoxColumn();
            columna2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna2.Name = "Columna Descipcion";
            columna2.HeaderText = "Descripción";
            dgvDatos.Columns.Add(columna2);
        }
    }
}
