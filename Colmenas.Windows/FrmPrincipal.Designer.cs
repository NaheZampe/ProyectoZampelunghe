namespace Colmenas.Windows
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSDBVer = new System.Windows.Forms.ToolStripDropDownButton();
            this.VerProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.VerAlimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.VerMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AgregarProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.Editar = new System.Windows.Forms.ToolStripDropDownButton();
            this.ProvinciaEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrarTSDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.BorrarProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrarAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.AgregarMedicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrarMedicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarMedd = new System.Windows.Forms.ToolStripMenuItem();
            this.VerCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSDBVer,
            this.toolStripDropDownButton1,
            this.Editar,
            this.BorrarTSDB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1546, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSDBVer
            // 
            this.tSDBVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSDBVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerProvincias,
            this.VerAlimentos,
            this.VerMedicamentos,
            this.VerCategorias});
            this.tSDBVer.Image = ((System.Drawing.Image)(resources.GetObject("tSDBVer.Image")));
            this.tSDBVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDBVer.Name = "tSDBVer";
            this.tSDBVer.Size = new System.Drawing.Size(36, 22);
            this.tSDBVer.Text = "Ver";
            this.tSDBVer.ToolTipText = "Ver";
            // 
            // VerProvincias
            // 
            this.VerProvincias.Name = "VerProvincias";
            this.VerProvincias.Size = new System.Drawing.Size(180, 22);
            this.VerProvincias.Text = "Provincias";
            this.VerProvincias.Click += new System.EventHandler(this.provinciasToolStripMenuItem_Click);
            // 
            // VerAlimentos
            // 
            this.VerAlimentos.Name = "VerAlimentos";
            this.VerAlimentos.Size = new System.Drawing.Size(180, 22);
            this.VerAlimentos.Text = "Alimentos";
            this.VerAlimentos.Click += new System.EventHandler(this.VerAlimentos_Click);
            // 
            // VerMedicamentos
            // 
            this.VerMedicamentos.Name = "VerMedicamentos";
            this.VerMedicamentos.Size = new System.Drawing.Size(180, 22);
            this.VerMedicamentos.Text = "Medicamentos";
            this.VerMedicamentos.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarProvincia,
            this.AgregarAlimento,
            this.AgregarMedicamento,
            this.AgregarCategoria});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Agregar";
            // 
            // AgregarProvincia
            // 
            this.AgregarProvincia.Name = "AgregarProvincia";
            this.AgregarProvincia.Size = new System.Drawing.Size(180, 22);
            this.AgregarProvincia.Text = "Provincia";
            this.AgregarProvincia.Click += new System.EventHandler(this.provinciaToolStripMenuItem_Click);
            // 
            // AgregarAlimento
            // 
            this.AgregarAlimento.Name = "AgregarAlimento";
            this.AgregarAlimento.Size = new System.Drawing.Size(180, 22);
            this.AgregarAlimento.Text = "Alimento";
            this.AgregarAlimento.Click += new System.EventHandler(this.AgregarAlimento_Click);
            // 
            // Editar
            // 
            this.Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProvinciaEditar,
            this.EditarAlimento,
            this.EditarMedd});
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(50, 22);
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Editar";
            // 
            // ProvinciaEditar
            // 
            this.ProvinciaEditar.Name = "ProvinciaEditar";
            this.ProvinciaEditar.Size = new System.Drawing.Size(180, 22);
            this.ProvinciaEditar.Text = "Provincia";
            this.ProvinciaEditar.Click += new System.EventHandler(this.ProvinciaEditar_Click);
            // 
            // EditarAlimento
            // 
            this.EditarAlimento.Name = "EditarAlimento";
            this.EditarAlimento.Size = new System.Drawing.Size(180, 22);
            this.EditarAlimento.Text = "Alimento";
            this.EditarAlimento.Click += new System.EventHandler(this.EditarAlimento_Click);
            // 
            // BorrarTSDB
            // 
            this.BorrarTSDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BorrarTSDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BorrarProvincia,
            this.BorrarAlimento,
            this.BorrarMedicamento});
            this.BorrarTSDB.Image = ((System.Drawing.Image)(resources.GetObject("BorrarTSDB.Image")));
            this.BorrarTSDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarTSDB.Name = "BorrarTSDB";
            this.BorrarTSDB.Size = new System.Drawing.Size(52, 22);
            this.BorrarTSDB.Text = "Borrar";
            // 
            // BorrarProvincia
            // 
            this.BorrarProvincia.Name = "BorrarProvincia";
            this.BorrarProvincia.Size = new System.Drawing.Size(180, 22);
            this.BorrarProvincia.Text = "Provincia";
            this.BorrarProvincia.Click += new System.EventHandler(this.BorrarProvincia_Click);
            // 
            // BorrarAlimento
            // 
            this.BorrarAlimento.Name = "BorrarAlimento";
            this.BorrarAlimento.Size = new System.Drawing.Size(180, 22);
            this.BorrarAlimento.Text = "Alimento";
            this.BorrarAlimento.Click += new System.EventHandler(this.BorrarAlimento_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 25);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(1546, 609);
            this.dgvDatos.TabIndex = 1;
            // 
            // AgregarMedicamento
            // 
            this.AgregarMedicamento.Name = "AgregarMedicamento";
            this.AgregarMedicamento.Size = new System.Drawing.Size(180, 22);
            this.AgregarMedicamento.Text = "Medicamento";
            this.AgregarMedicamento.Click += new System.EventHandler(this.AgregarMedicamento_Click);
            // 
            // BorrarMedicamento
            // 
            this.BorrarMedicamento.Name = "BorrarMedicamento";
            this.BorrarMedicamento.Size = new System.Drawing.Size(180, 22);
            this.BorrarMedicamento.Text = "Medicamento";
            this.BorrarMedicamento.Click += new System.EventHandler(this.BorrarMedicamento_Click);
            // 
            // EditarMedd
            // 
            this.EditarMedd.Name = "EditarMedd";
            this.EditarMedd.Size = new System.Drawing.Size(180, 22);
            this.EditarMedd.Text = "Medicamento";
            this.EditarMedd.Click += new System.EventHandler(this.EditarMedd_Click);
            // 
            // VerCategorias
            // 
            this.VerCategorias.Name = "VerCategorias";
            this.VerCategorias.Size = new System.Drawing.Size(180, 22);
            this.VerCategorias.Text = "Categorias";
            this.VerCategorias.Click += new System.EventHandler(this.VerCategorias_Click);
            // 
            // AgregarCategoria
            // 
            this.AgregarCategoria.Name = "AgregarCategoria";
            this.AgregarCategoria.Size = new System.Drawing.Size(180, 22);
            this.AgregarCategoria.Text = "Categoria";
            this.AgregarCategoria.Click += new System.EventHandler(this.AgregarCategoria_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 634);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(1562, 673);
            this.MinimumSize = new System.Drawing.Size(1562, 673);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colmenas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tSDBVer;
        private System.Windows.Forms.ToolStripMenuItem VerProvincias;
        private System.Windows.Forms.ToolStripMenuItem VerAlimentos;
        private System.Windows.Forms.ToolStripMenuItem VerMedicamentos;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AgregarProvincia;
        private System.Windows.Forms.ToolStripDropDownButton Editar;
        private System.Windows.Forms.ToolStripMenuItem ProvinciaEditar;
        private System.Windows.Forms.ToolStripDropDownButton BorrarTSDB;
        private System.Windows.Forms.ToolStripMenuItem BorrarProvincia;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStripMenuItem AgregarAlimento;
        private System.Windows.Forms.ToolStripMenuItem EditarAlimento;
        private System.Windows.Forms.ToolStripMenuItem BorrarAlimento;
        private System.Windows.Forms.ToolStripMenuItem AgregarMedicamento;
        private System.Windows.Forms.ToolStripMenuItem BorrarMedicamento;
        private System.Windows.Forms.ToolStripMenuItem EditarMedd;
        private System.Windows.Forms.ToolStripMenuItem VerCategorias;
        private System.Windows.Forms.ToolStripMenuItem AgregarCategoria;
    }
}

