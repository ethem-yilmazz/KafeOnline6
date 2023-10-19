namespace KafeOnline6
{
	partial class GecmisSiparislerForm
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
			splitContainer1 = new SplitContainer();
			dgvSiparisler = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			dgvSiparisDetaylar = new DataGridView();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(dgvSiparisler);
			splitContainer1.Panel1.Controls.Add(label1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(label2);
			splitContainer1.Panel2.Controls.Add(dgvSiparisDetaylar);
			splitContainer1.Size = new Size(860, 602);
			splitContainer1.SplitterDistance = 300;
			splitContainer1.TabIndex = 0;
			// 
			// dgvSiparisler
			// 
			dgvSiparisler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSiparisler.Location = new Point(12, 47);
			dgvSiparisler.Name = "dgvSiparisler";
			dgvSiparisler.RowHeadersWidth = 51;
			dgvSiparisler.RowTemplate.Height = 29;
			dgvSiparisler.Size = new Size(836, 230);
			dgvSiparisler.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(92, 28);
			label1.TabIndex = 0;
			label1.Text = "Siparişler";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(32, 10);
			label2.Name = "label2";
			label2.Size = new Size(153, 28);
			label2.TabIndex = 1;
			label2.Text = "Sipariş Detayları";
			// 
			// dgvSiparisDetaylar
			// 
			dgvSiparisDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSiparisDetaylar.Location = new Point(12, 41);
			dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
			dgvSiparisDetaylar.RowHeadersWidth = 51;
			dgvSiparisDetaylar.RowTemplate.Height = 29;
			dgvSiparisDetaylar.Size = new Size(836, 245);
			dgvSiparisDetaylar.TabIndex = 0;
			// 
			// GecmisSiparislerForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(860, 602);
			Controls.Add(splitContainer1);
			Name = "GecmisSiparislerForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Gecmiş Siparisler";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private DataGridView dgvSiparisler;
		private Label label1;
		private Label label2;
		private DataGridView dgvSiparisDetaylar;
	}
}