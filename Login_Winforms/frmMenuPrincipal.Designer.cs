namespace Login_Winforms
{
	partial class frmMenuPrincipal
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
			PrincipalMenuStrip = new MenuStrip();
			sistemaToolStripMenuItem = new ToolStripMenuItem();
			salirToolStripMenuItem = new ToolStripMenuItem();
			PrincipalStatusStrip = new StatusStrip();
			ServerDateToolStripStatusLabel = new ToolStripStatusLabel();
			StatusToolStripStatusLabel = new ToolStripStatusLabel();
			PrincipalMenuStrip.SuspendLayout();
			PrincipalStatusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// PrincipalMenuStrip
			// 
			PrincipalMenuStrip.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem });
			PrincipalMenuStrip.Location = new Point(0, 0);
			PrincipalMenuStrip.Name = "PrincipalMenuStrip";
			PrincipalMenuStrip.Size = new Size(800, 24);
			PrincipalMenuStrip.TabIndex = 1;
			PrincipalMenuStrip.Text = "menuStrip1";
			// 
			// sistemaToolStripMenuItem
			// 
			sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
			sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			sistemaToolStripMenuItem.Size = new Size(60, 20);
			sistemaToolStripMenuItem.Text = "&Sistema";
			// 
			// salirToolStripMenuItem
			// 
			salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			salirToolStripMenuItem.Size = new Size(96, 22);
			salirToolStripMenuItem.Text = "Sali&r";
			salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
			// 
			// PrincipalStatusStrip
			// 
			PrincipalStatusStrip.Items.AddRange(new ToolStripItem[] { StatusToolStripStatusLabel, ServerDateToolStripStatusLabel });
			PrincipalStatusStrip.Location = new Point(0, 426);
			PrincipalStatusStrip.Name = "PrincipalStatusStrip";
			PrincipalStatusStrip.Size = new Size(800, 24);
			PrincipalStatusStrip.TabIndex = 3;
			PrincipalStatusStrip.Text = "statusStrip1";
			// 
			// ServerDateToolStripStatusLabel
			// 
			ServerDateToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			ServerDateToolStripStatusLabel.Name = "ServerDateToolStripStatusLabel";
			ServerDateToolStripStatusLabel.Size = new Size(88, 19);
			ServerDateToolStripStatusLabel.Text = "{SERVER DATE}";
			// 
			// StatusToolStripStatusLabel
			// 
			StatusToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
			StatusToolStripStatusLabel.Size = new Size(697, 19);
			StatusToolStripStatusLabel.Spring = true;
			// 
			// frmMenuPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(PrincipalStatusStrip);
			Controls.Add(PrincipalMenuStrip);
			IsMdiContainer = true;
			MainMenuStrip = PrincipalMenuStrip;
			Name = "frmMenuPrincipal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Menú Principal";
			WindowState = FormWindowState.Maximized;
			PrincipalMenuStrip.ResumeLayout(false);
			PrincipalMenuStrip.PerformLayout();
			PrincipalStatusStrip.ResumeLayout(false);
			PrincipalStatusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip PrincipalMenuStrip;
		private ToolStripMenuItem sistemaToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private StatusStrip PrincipalStatusStrip;
		private ToolStripStatusLabel StatusToolStripStatusLabel;
		private ToolStripStatusLabel ServerDateToolStripStatusLabel;
	}
}