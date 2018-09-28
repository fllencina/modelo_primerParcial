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
        public frmVista()
        {
            InitializeComponent();
        }

        private void cmbDivisionCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource=Enum.GetValues(typeof(Divisiones));
        }
    }
}
