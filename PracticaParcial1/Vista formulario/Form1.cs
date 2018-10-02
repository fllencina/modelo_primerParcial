using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaParcial1;

namespace Vista_formulario
{
    public partial class frmVista : Form
    {
        private Curso curso;
        private Profesor Profe;
        private Alumno alumno;
        public frmVista()
        {
            InitializeComponent();
        }

        private void cmbDivisionCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombreProfe.Text.Length > 0 && txtApellidoProfe.Text.Length > 0 && txtDocumentoProfe.Text.Length > 0)
            {
                Profe = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value);
                Divisiones division;

                if (Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division))
                {

                    curso = new Curso((short)nudAnioCurso.Value, division, Profe);
                    MessageBox.Show("Se ha creado un nuevo curso", "Alta de curso");
                }
            }
            else
            {
                MessageBox.Show("No se pudo crear un nuevo curso", "Alta de curso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtNombreProfe.Text = "";
            txtApellidoProfe.Text = "";
            txtDocumentoProfe.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            nudAnioCurso.Value = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (curso is null)
            {
                MessageBox.Show("El curso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbDatos.Text = curso.AnioDivision + "\n" + Profe.ExponerDatos() + "\n" + (string)curso;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division;

            if (Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division))
            {
                if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtDocumento.Text.Length > 0 && (short)nudAnio.Value > 0)
                {
                    alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, division);
                    curso += alumno;
                    MessageBox.Show("El alumno fue ingresado al curso", "Alta de alumno");
                }
                else
                {
                    MessageBox.Show("El alumno no pudo ser ingresado al curso", "Alta de alumno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            nudAnio.Value = 0;
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void frmVista_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Consulta = new DialogResult();
            Consulta = MessageBox.Show("Desea cerrar la aplicacion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (Consulta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
