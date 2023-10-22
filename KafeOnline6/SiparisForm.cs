using KafeOnline6.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOnline6
{
	public partial class SiparisForm : Form
	{
		private readonly KafeVeri db;
		private readonly Siparis siparis;

		public SiparisForm(KafeVeri db, Siparis siparis)
		{
			InitializeComponent();
			this.db = db;
			this.siparis = siparis;
			cboUrun.DataSource = this.db.Urunler;
			DetaylarListele();
			Guncelle();
		}

		private void DetaylarListele()
		{
			dgvDetaylar.DataSource = siparis.SiparisDetaylar.ToList();
			Guncelle();
		}

		private void Guncelle()
		{
			Text = "Masa " + siparis.MasaNo;
			lblMasaNo.Text = siparis.MasaNo.ToString("00");
			lblOdemeTutari.Text = siparis.ToplamTutarTL;
		}

		private void btnDetayEkle_Click(object sender, EventArgs e)
		{
			if (cboUrun.SelectedItem == null) return;
			Urun urun = (Urun)cboUrun.SelectedItem;
			SiparisDetay sd = new SiparisDetay();
			sd.UrunAd = urun.UrunAd;
			sd.BirimFiyat = urun.BirimFiyat;
			sd.Adet = (int)nudAdet.Value;
			this.siparis.SiparisDetaylar.Add(sd);
			DetaylarListele();
		}

		private void dgvDetaylar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && dgvDetaylar.SelectedRows.Count > 0)
			{
				SiparisDetay sd = (SiparisDetay)dgvDetaylar.SelectedRows[0].DataBoundItem;
				siparis.SiparisDetaylar.Remove(sd);
				DetaylarListele();
			}
		}

		private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSiparisIptal_Click(object sender, EventArgs e)
		{
			SiparisiKapat(SiparisDurum.Iptal, 0);
		}

		private void SiparisiKapat(SiparisDurum durum, decimal odenenTutar)
		{
			siparis.KapanisZamani = DateTime.Now;
			siparis.OdenecekTutar = odenenTutar;
			siparis.Durum = durum;
			db.AktifSiparisler.Remove(siparis);
			db.GecmisSiparisler.Add(siparis);
			Close();
		}

		private void btnOdemeAl_Click(object sender, EventArgs e)
		{
			SiparisiKapat(SiparisDurum.Odendi, siparis.ToplamTutar());
		}
	}
}
