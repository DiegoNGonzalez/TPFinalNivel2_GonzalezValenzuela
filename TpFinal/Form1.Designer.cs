namespace TpFinal
{
    partial class FormCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picBoxArticulo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.gBoxFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cBoxCriterio = new System.Windows.Forms.ComboBox();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.gBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscarRapido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).BeginInit();
            this.gBoxFiltro.SuspendLayout();
            this.gBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(270, 118);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(564, 360);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::TpFinal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Azure;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(553, 496);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 31);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Azure;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(457, 496);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 31);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Azure;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(366, 496);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picBoxArticulo
            // 
            this.picBoxArticulo.Location = new System.Drawing.Point(866, 118);
            this.picBoxArticulo.Name = "picBoxArticulo";
            this.picBoxArticulo.Size = new System.Drawing.Size(227, 360);
            this.picBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArticulo.TabIndex = 1;
            this.picBoxArticulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(484, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(137, 33);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Articulos";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.Azure;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerDetalle.Location = new System.Drawing.Point(658, 496);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(80, 31);
            this.btnVerDetalle.TabIndex = 8;
            this.btnVerDetalle.Text = "Ver Detalles";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // gBoxFiltro
            // 
            this.gBoxFiltro.Controls.Add(this.btnLimpiar);
            this.gBoxFiltro.Controls.Add(this.btnBuscar);
            this.gBoxFiltro.Controls.Add(this.txtFiltro);
            this.gBoxFiltro.Controls.Add(this.cBoxCriterio);
            this.gBoxFiltro.Controls.Add(this.cboxCampo);
            this.gBoxFiltro.Controls.Add(this.lblFiltro);
            this.gBoxFiltro.Controls.Add(this.lblCriterio);
            this.gBoxFiltro.Controls.Add(this.lblCampo);
            this.gBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFiltro.Location = new System.Drawing.Point(11, 202);
            this.gBoxFiltro.Name = "gBoxFiltro";
            this.gBoxFiltro.Size = new System.Drawing.Size(219, 324);
            this.gBoxFiltro.TabIndex = 10;
            this.gBoxFiltro.TabStop = false;
            this.gBoxFiltro.Text = "Filtrar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(122, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(22, 240);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(10, 184);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(121, 26);
            this.txtFiltro.TabIndex = 5;
            // 
            // cBoxCriterio
            // 
            this.cBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCriterio.FormattingEnabled = true;
            this.cBoxCriterio.Location = new System.Drawing.Point(11, 120);
            this.cBoxCriterio.Name = "cBoxCriterio";
            this.cBoxCriterio.Size = new System.Drawing.Size(121, 28);
            this.cBoxCriterio.TabIndex = 4;
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(11, 57);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(121, 28);
            this.cboxCampo.TabIndex = 3;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(11, 161);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 20);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(11, 97);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(72, 20);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(7, 34);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(70, 20);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // gBoxBusqueda
            // 
            this.gBoxBusqueda.Controls.Add(this.txtBuscarRapido);
            this.gBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxBusqueda.Location = new System.Drawing.Point(12, 118);
            this.gBoxBusqueda.Name = "gBoxBusqueda";
            this.gBoxBusqueda.Size = new System.Drawing.Size(219, 78);
            this.gBoxBusqueda.TabIndex = 11;
            this.gBoxBusqueda.TabStop = false;
            this.gBoxBusqueda.Text = "Busqueda Rapida";
            // 
            // txtBuscarRapido
            // 
            this.txtBuscarRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRapido.Location = new System.Drawing.Point(19, 35);
            this.txtBuscarRapido.Name = "txtBuscarRapido";
            this.txtBuscarRapido.Size = new System.Drawing.Size(178, 26);
            this.txtBuscarRapido.TabIndex = 12;
            this.txtBuscarRapido.TextChanged += new System.EventHandler(this.txtBuscarRapido_TextChanged);
            // 
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1105, 643);
            this.Controls.Add(this.gBoxBusqueda);
            this.Controls.Add(this.gBoxFiltro);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.picBoxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "FormCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Articulos";
            this.Load += new System.EventHandler(this.FormCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).EndInit();
            this.gBoxFiltro.ResumeLayout(false);
            this.gBoxFiltro.PerformLayout();
            this.gBoxBusqueda.ResumeLayout(false);
            this.gBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox picBoxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.GroupBox gBoxFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cBoxCriterio;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gBoxBusqueda;
        private System.Windows.Forms.TextBox txtBuscarRapido;
    }
}

