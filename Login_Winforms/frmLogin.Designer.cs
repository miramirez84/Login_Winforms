namespace Login_Winforms
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			lblUsuario = new Label();
			lblPassword = new Label();
			txtUsuario = new TextBox();
			txtPassword = new TextBox();
			btnCancelar = new Button();
			btnAceptar = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pictureBox1.Image = Properties.Resources.img_login;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Margin = new Padding(4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(184, 232);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.ForeColor = Color.White;
			lblUsuario.Location = new Point(192, 49);
			lblUsuario.Margin = new Padding(4, 0, 4, 0);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(62, 20);
			lblUsuario.TabIndex = 1;
			lblUsuario.Text = "Usuario:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.ForeColor = Color.White;
			lblPassword.Location = new Point(192, 102);
			lblPassword.Margin = new Padding(4, 0, 4, 0);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(86, 20);
			lblPassword.TabIndex = 1;
			lblPassword.Text = "Contraseña:";
			// 
			// txtUsuario
			// 
			txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtUsuario.Location = new Point(193, 72);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(257, 27);
			txtUsuario.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtPassword.Location = new Point(192, 125);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(258, 27);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnCancelar
			// 
			btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCancelar.Location = new Point(374, 189);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 29);
			btnCancelar.TabIndex = 2;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnAceptar
			// 
			btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAceptar.Location = new Point(293, 189);
			btnAceptar.Name = "btnAceptar";
			btnAceptar.Size = new Size(75, 29);
			btnAceptar.TabIndex = 2;
			btnAceptar.Text = "Aceptar";
			btnAceptar.UseVisualStyleBackColor = true;
			btnAceptar.Click += btnAceptar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.White;
			label1.Location = new Point(293, 9);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(69, 20);
			label1.TabIndex = 1;
			label1.Text = "Cliente A";
			// 
			// frmLogin
			// 
			AcceptButton = btnAceptar;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SteelBlue;
			CancelButton = btnCancelar;
			ClientSize = new Size(461, 230);
			Controls.Add(btnAceptar);
			Controls.Add(btnCancelar);
			Controls.Add(txtPassword);
			Controls.Add(txtUsuario);
			Controls.Add(lblPassword);
			Controls.Add(label1);
			Controls.Add(lblUsuario);
			Controls.Add(pictureBox1);
			Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Control de Acceso...";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label lblUsuario;
		private Label lblPassword;
		private TextBox txtUsuario;
		private TextBox txtPassword;
		private Button btnCancelar;
		private Button btnAceptar;
		private Label label1;
	}
}