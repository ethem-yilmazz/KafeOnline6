namespace KafeOnline6
{
	partial class SiparisForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			label1 = new Label();
			btnDetayEkle = new Button();
			dgvDetaylar = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			nudAdet = new NumericUpDown();
			cboUrun = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			cboMasaNo = new ComboBox();
			btnMasaTasi = new Button();
			lblMasaNo = new Label();
			label6 = new Label();
			lblOdemeTutari = new Label();
			btnSiparisIptal = new Button();
			btnOdemeAl = new Button();
			btnAnaSayfayaDon = new Button();
			((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 26);
			label1.Name = "label1";
			label1.Size = new Size(44, 20);
			label1.TabIndex = 0;
			label1.Text = "Ürün";
			// 
			// btnDetayEkle
			// 
			btnDetayEkle.Location = new Point(425, 48);
			btnDetayEkle.Name = "btnDetayEkle";
			btnDetayEkle.Size = new Size(106, 29);
			btnDetayEkle.TabIndex = 4;
			btnDetayEkle.Text = "EKLE";
			btnDetayEkle.UseVisualStyleBackColor = true;
			btnDetayEkle.Click += btnDetayEkle_Click;
			// 
			// dgvDetaylar
			// 
			dgvDetaylar.AllowUserToAddRows = false;
			dgvDetaylar.AllowUserToDeleteRows = false;
			dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
			dgvDetaylar.Location = new Point(3, 83);
			dgvDetaylar.MultiSelect = false;
			dgvDetaylar.Name = "dgvDetaylar";
			dgvDetaylar.ReadOnly = true;
			dgvDetaylar.RowHeadersVisible = false;
			dgvDetaylar.RowHeadersWidth = 51;
			dgvDetaylar.RowTemplate.Height = 29;
			dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDetaylar.Size = new Size(528, 334);
			dgvDetaylar.TabIndex = 8;
			dgvDetaylar.KeyDown += dgvDetaylar_KeyDown;
			// 
			// Column1
			// 
			Column1.DataPropertyName = "UrunAd";
			Column1.HeaderText = "Ürün Ad";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			// 
			// Column2
			// 
			Column2.DataPropertyName = "BirimFiyat";
			dataGridViewCellStyle1.Format = "c2";
			Column2.DefaultCellStyle = dataGridViewCellStyle1;
			Column2.HeaderText = "Birim Fiyat";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			// 
			// Column3
			// 
			Column3.DataPropertyName = "Adet";
			Column3.HeaderText = "Adet";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// Column4
			// 
			Column4.DataPropertyName = "TutarTL";
			Column4.HeaderText = "Tutar";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			// 
			// nudAdet
			// 
			nudAdet.Location = new Point(302, 49);
			nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudAdet.Name = "nudAdet";
			nudAdet.Size = new Size(117, 28);
			nudAdet.TabIndex = 3;
			nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// cboUrun
			// 
			cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
			cboUrun.FormattingEnabled = true;
			cboUrun.Location = new Point(3, 49);
			cboUrun.Name = "cboUrun";
			cboUrun.Size = new Size(291, 28);
			cboUrun.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(302, 26);
			label2.Name = "label2";
			label2.Size = new Size(41, 20);
			label2.TabIndex = 1;
			label2.Text = "Adet";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(674, 9);
			label3.Name = "label3";
			label3.Size = new Size(74, 20);
			label3.TabIndex = 5;
			label3.Text = "Masa No:";
			// 
			// cboMasaNo
			// 
			cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
			cboMasaNo.FormattingEnabled = true;
			cboMasaNo.Location = new Point(674, 38);
			cboMasaNo.Name = "cboMasaNo";
			cboMasaNo.Size = new Size(105, 28);
			cboMasaNo.TabIndex = 6;
			// 
			// btnMasaTasi
			// 
			btnMasaTasi.Location = new Point(786, 37);
			btnMasaTasi.Name = "btnMasaTasi";
			btnMasaTasi.Size = new Size(106, 29);
			btnMasaTasi.TabIndex = 7;
			btnMasaTasi.Text = "TAŞI";
			btnMasaTasi.UseVisualStyleBackColor = true;
			// 
			// lblMasaNo
			// 
			lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblMasaNo.BackColor = Color.Tomato;
			lblMasaNo.Font = new Font("Impact", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point);
			lblMasaNo.Location = new Point(592, 83);
			lblMasaNo.Name = "lblMasaNo";
			lblMasaNo.Size = new Size(295, 169);
			lblMasaNo.TabIndex = 9;
			lblMasaNo.Text = "00";
			lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Right;
			label6.AutoSize = true;
			label6.Location = new Point(603, 266);
			label6.Name = "label6";
			label6.Size = new Size(111, 20);
			label6.TabIndex = 10;
			label6.Text = "Ödeme Tutarı :";
			// 
			// lblOdemeTutari
			// 
			lblOdemeTutari.Anchor = AnchorStyles.Right;
			lblOdemeTutari.AutoSize = true;
			lblOdemeTutari.Location = new Point(740, 266);
			lblOdemeTutari.Name = "lblOdemeTutari";
			lblOdemeTutari.Size = new Size(48, 20);
			lblOdemeTutari.TabIndex = 11;
			lblOdemeTutari.Text = "₺0,00";
			// 
			// btnSiparisIptal
			// 
			btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSiparisIptal.BackColor = Color.Brown;
			btnSiparisIptal.ForeColor = SystemColors.HighlightText;
			btnSiparisIptal.Location = new Point(603, 289);
			btnSiparisIptal.Name = "btnSiparisIptal";
			btnSiparisIptal.Size = new Size(130, 60);
			btnSiparisIptal.TabIndex = 12;
			btnSiparisIptal.Text = "SİPARİŞ İPTAL";
			btnSiparisIptal.UseVisualStyleBackColor = false;
			btnSiparisIptal.Click += btnSiparisIptal_Click;
			// 
			// btnOdemeAl
			// 
			btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnOdemeAl.BackColor = Color.Green;
			btnOdemeAl.ForeColor = SystemColors.HighlightText;
			btnOdemeAl.Location = new Point(741, 289);
			btnOdemeAl.Name = "btnOdemeAl";
			btnOdemeAl.Size = new Size(130, 60);
			btnOdemeAl.TabIndex = 13;
			btnOdemeAl.Text = "ÖDEME AL";
			btnOdemeAl.UseVisualStyleBackColor = false;
			btnOdemeAl.Click += btnOdemeAl_Click;
			// 
			// btnAnaSayfayaDon
			// 
			btnAnaSayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAnaSayfayaDon.BackColor = Color.Gold;
			btnAnaSayfayaDon.ForeColor = SystemColors.HighlightText;
			btnAnaSayfayaDon.Location = new Point(605, 355);
			btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
			btnAnaSayfayaDon.Size = new Size(266, 43);
			btnAnaSayfayaDon.TabIndex = 14;
			btnAnaSayfayaDon.Text = "ANASAYFAYA DÖN";
			btnAnaSayfayaDon.UseVisualStyleBackColor = false;
			btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
			// 
			// SiparisForm
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(900, 450);
			Controls.Add(btnAnaSayfayaDon);
			Controls.Add(btnOdemeAl);
			Controls.Add(btnSiparisIptal);
			Controls.Add(lblOdemeTutari);
			Controls.Add(label6);
			Controls.Add(lblMasaNo);
			Controls.Add(btnMasaTasi);
			Controls.Add(cboMasaNo);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(cboUrun);
			Controls.Add(nudAdet);
			Controls.Add(dgvDetaylar);
			Controls.Add(btnDetayEkle);
			Controls.Add(label1);
			Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			Name = "SiparisForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Masa 0";
			((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
			((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnDetayEkle;
		private DataGridView dgvDetaylar;
		private NumericUpDown nudAdet;
		private ComboBox cboUrun;
		private Label label2;
		private Label label3;
		private ComboBox cboMasaNo;
		private Button btnMasaTasi;
		private Label lblMasaNo;
		private Label label6;
		private Label lblOdemeTutari;
		private Button btnSiparisIptal;
		private Button btnOdemeAl;
		private Button btnAnaSayfayaDon;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
	}
}