namespace Vista_formulario
{
    partial class frmVista
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
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.rbtDatos = new System.Windows.Forms.RichTextBox();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpbDatosCurso.SuspendLayout();
            this.gpbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrear);
            this.gpbDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gpbDatosCurso.Controls.Add(this.lblIngreso);
            this.gpbDatosCurso.Controls.Add(this.lblDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.lblAnioCurso);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(326, 232);
            this.gpbDatosCurso.TabIndex = 0;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumno.Controls.Add(this.cmbDivision);
            this.gpbDatosAlumno.Controls.Add(this.nudAnio);
            this.gpbDatosAlumno.Controls.Add(this.lblDivision);
            this.gpbDatosAlumno.Controls.Add(this.lblAnio);
            this.gpbDatosAlumno.Controls.Add(this.txtDocumento);
            this.gpbDatosAlumno.Controls.Add(this.txtApellido);
            this.gpbDatosAlumno.Controls.Add(this.txtNombre);
            this.gpbDatosAlumno.Controls.Add(this.lblDocumento);
            this.gpbDatosAlumno.Controls.Add(this.lblApellido);
            this.gpbDatosAlumno.Controls.Add(this.lblNombre);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(359, 12);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(335, 232);
            this.gpbDatosAlumno.TabIndex = 1;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Alumno";
            // 
            // rbtDatos
            // 
            this.rbtDatos.Location = new System.Drawing.Point(12, 250);
            this.rbtDatos.Name = "rbtDatos";
            this.rbtDatos.Size = new System.Drawing.Size(682, 132);
            this.rbtDatos.TabIndex = 2;
            this.rbtDatos.Text = "";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(12, 30);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 0;
            this.lblAnioCurso.Text = "Año";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(12, 56);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 1;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(12, 82);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 2;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(12, 108);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 3;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(12, 134);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 4;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(12, 160);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 5;
            this.lblIngreso.Text = "Ingreso";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(108, 28);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(120, 20);
            this.nudAnioCurso.TabIndex = 6;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(108, 54);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(120, 21);
            this.cmbDivisionCurso.TabIndex = 7;
            this.cmbDivisionCurso.SelectedIndexChanged += new System.EventHandler(this.cmbDivisionCurso_SelectedIndexChanged);
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(108, 81);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(207, 20);
            this.txtNombreProfe.TabIndex = 8;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(108, 107);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(207, 20);
            this.txtApellidoProfe.TabIndex = 9;
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(108, 133);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(207, 20);
            this.txtDocumentoProfe.TabIndex = 10;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(108, 159);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(207, 20);
            this.dtpFechaIngreso.TabIndex = 11;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 186);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(105, 40);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(210, 186);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(105, 40);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(105, 87);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(207, 20);
            this.txtDocumento.TabIndex = 16;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(105, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(207, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(9, 88);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(39, 13);
            this.lblDocumento.TabIndex = 13;
            this.lblDocumento.Text = "Legajo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(105, 143);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(120, 21);
            this.cmbDivision.TabIndex = 20;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(105, 115);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 19;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(9, 144);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 18;
            this.lblDivision.Text = "Division";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(9, 116);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 17;
            this.lblAnio.Text = "Año";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(207, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 40);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 394);
            this.Controls.Add(this.rbtDatos);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "frmVista";
            this.Text = "Vista del Curso";
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.RichTextBox rbtDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}

