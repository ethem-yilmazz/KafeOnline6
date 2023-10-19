namespace KafeOnline6
{
	partial class UrunlerForm
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
			txtUrunAd = new TextBox();
			label1 = new Label();
			btnEkle = new Button();
			dgvUrunler = new DataGridView();
			nudBirimFiyat = new NumericUpDown();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
			SuspendLayout();
			// 
			// txtUrunAd
			// 
			txtUrunAd.Location = new Point(12, 52);
			txtUrunAd.Name = "txtUrunAd";
			txtUrunAd.Size = new Size(144, 27);
			txtUrunAd.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 29);
			label1.Name = "label1";
			label1.Size = new Size(67, 20);
			label1.TabIndex = 1;
			label1.Text = "Ürün Adı";
			// 
			// btnEkle
			// 
			btnEkle.Location = new Point(318, 50);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(111, 29);
			btnEkle.TabIndex = 2;
			btnEkle.Text = "EKLE";
			btnEkle.UseVisualStyleBackColor = true;
			// 
			// dgvUrunler
			// 
			dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUrunler.Location = new Point(12, 85);
			dgvUrunler.Name = "dgvUrunler";
			dgvUrunler.RowHeadersWidth = 51;
			dgvUrunler.RowTemplate.Height = 29;
			dgvUrunler.Size = new Size(417, 335);
			dgvUrunler.TabIndex = 3;
			// 
			// nudBirimFiyat
			// 
			nudBirimFiyat.Location = new Point(162, 52);
			nudBirimFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			nudBirimFiyat.Name = "nudBirimFiyat";
			nudBirimFiyat.Size = new Size(150, 27);
			nudBirimFiyat.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(162, 29);
			label2.Name = "label2";
			label2.Size = new Size(97, 20);
			label2.TabIndex = 5;
			label2.Text = "Birim Fiyat(₺)";
			// 
			// UrunlerForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(515, 465);
			Controls.Add(label2);
			Controls.Add(nudBirimFiyat);
			Controls.Add(dgvUrunler);
			Controls.Add(btnEkle);
			Controls.Add(label1);
			Controls.Add(txtUrunAd);
			Name = "UrunlerForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Ürünler";
			((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
			((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUrunAd;
		private Label label1;
		private Button btnEkle;
		private DataGridView dgvUrunler;
		private NumericUpDown nudBirimFiyat;
		private Label label2;
	}
}