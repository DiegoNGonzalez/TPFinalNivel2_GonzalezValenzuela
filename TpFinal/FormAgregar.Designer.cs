namespace TpFinal
{
    partial class FormAgregar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImgUrl = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.picBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // lblImgUrl
            // 
            this.lblImgUrl.AutoSize = true;
            this.lblImgUrl.Location = new System.Drawing.Point(16, 149);
            this.lblImgUrl.Name = "lblImgUrl";
            this.lblImgUrl.Size = new System.Drawing.Size(78, 13);
            this.lblImgUrl.TabIndex = 10;
            this.lblImgUrl.Text = "Url de imagen: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 180);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 213);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(16, 248);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(92, 103);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 31);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(92, 149);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(100, 20);
            this.txtUrlImg.TabIndex = 3;
            this.txtUrlImg.Leave += new System.EventHandler(this.txtUrlImg_Leave);
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(92, 248);
            this.numPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(100, 20);
            this.numPrecio.TabIndex = 6;
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(92, 180);
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.cBoxMarca.TabIndex = 4;
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(92, 213);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.cBoxCategoria.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(19, 313);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(133, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // picBoxArticulo
            // 
            this.picBoxArticulo.Location = new System.Drawing.Point(226, 44);
            this.picBoxArticulo.Name = "picBoxArticulo";
            this.picBoxArticulo.Size = new System.Drawing.Size(181, 224);
            this.picBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArticulo.TabIndex = 16;
            this.picBoxArticulo.TabStop = false;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 429);
            this.Controls.Add(this.picBoxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.cBoxMarca);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblImgUrl);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Modificar Articulo";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImgUrl;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picBoxArticulo;
    }
}