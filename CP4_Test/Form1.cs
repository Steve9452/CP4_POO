namespace CP4_Test
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using(frmFormulario frm = new frmFormulario())
            {
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    chkStatus.Checked = true;
                    chkStatus.Text = $"Estado: Logeado\nRol: {frm.credential.Rol}\nNombre: {frm.credential.Alias}";
                    chkStatus.ForeColor = Color.LightGreen;
                    btnExec.BackColor = Color.SpringGreen;
                    btnLogIn.Enabled = false;
                    btnExec.Enabled = true;
                }
                else MessageBox.Show("Acceso Denegado", "El nombre de usuario o contraseña son incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            frmMainApp mainApp = new frmMainApp();
            mainApp.Show();
            this.Hide();
        }
    }
}