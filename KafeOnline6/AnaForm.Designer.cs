namespace KafeOnline6
{
	partial class AnaForm
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
			menuStrip1 = new MenuStrip();
			tsmiUrunler = new ToolStripMenuItem();
			tsmiGecmisSiparisler = new ToolStripMenuItem();
			lvwMasalar = new ListView();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmisSiparisler });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(884, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// tsmiUrunler
			// 
			tsmiUrunler.Name = "tsmiUrunler";
			tsmiUrunler.Size = new Size(71, 24);
			tsmiUrunler.Text = "Ürünler";
			// 
			// tsmiGecmisSiparisler
			// 
			tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
			tsmiGecmisSiparisler.Size = new Size(136, 24);
			tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
			// 
			// lvwMasalar
			// 
			lvwMasalar.BackColor = SystemColors.Window;
			lvwMasalar.Dock = DockStyle.Fill;
			lvwMasalar.Location = new Point(0, 28);
			lvwMasalar.Name = "lvwMasalar";
			lvwMasalar.Size = new Size(884, 500);
			lvwMasalar.TabIndex = 1;
			lvwMasalar.UseCompatibleStateImageBehavior = false;
			lvwMasalar.SelectedIndexChanged += listView1_SelectedIndexChanged;
			// 
			// AnaForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(884, 528);
			Controls.Add(lvwMasalar);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "AnaForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Kafe Online6";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ListView lvwMasalar;
		private ToolStripMenuItem tsmiUrunler;
		private ToolStripMenuItem tsmiGecmisSiparisler;
	}
}