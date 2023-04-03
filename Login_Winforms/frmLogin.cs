namespace Login_Winforms
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Dispose();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (txtUsuario.Text == string.Empty)
			{
				MessageBox.Show("Debe introducir el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;

			}
			if (txtPassword.Text == string.Empty)
			{
				MessageBox.Show("Debe introducir la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPassword.Focus();
				return;
			}

			if (!Manager.Login.getAccess(txtUsuario.Text, txtPassword.Text))
			{
				MessageBox.Show("Usuario/Contraseña incorrectos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;
			}

			DialogResult = DialogResult.OK;
			this.Dispose();

		}
	}
}