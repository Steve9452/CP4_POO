using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP4_Test
{
    public partial class frmFormulario : Form
    {
        // Definicion de credenciales
        public Repository credential { get; set; }
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = Validation.login(txtName.Text, txtPass.Text) ? DialogResult.OK : DialogResult.Cancel;
            credential = new Repository(txtNickName.Text, "Administrador");

            // Retorno el resultado del formulario
            this.DialogResult = dialogResult;
        }
    }
}
