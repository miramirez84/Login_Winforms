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
				MessageBox.Show("Debe introducir el usuario", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;

			}
			if (txtPassword.Text == string.Empty)
			{
				MessageBox.Show("Debe introducir la contrase�a", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPassword.Focus();
				return;
			}

			if (!Manager.Login.getAccess(txtUsuario.Text, txtPassword.Text))
			{
				MessageBox.Show("Usuario/Contrase�a incorrectos!", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;
			}

			DialogResult = DialogResult.OK;
			this.Dispose();

		}
	}
}