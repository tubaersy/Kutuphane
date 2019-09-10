using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    public partial class frmUYE : Form
    {
        KUTUPHANEEntities6 db = new KUTUPHANEEntities6();
        int satir = -1;

        
        public frmUYE()
        {
            InitializeComponent();
        }
        private void FrmUYE_Load(object sender, EventArgs e)
        {
            var liste = db.UYEs.ToList();
            dataGridView1.DataSource = liste;
            cmbDURUMU.Items.Add("Aktif");
            cmbDURUMU.Items.Add("Pasif");
        }

        private void DataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                txtAD_SOYAD.Text = dataGridView1.Rows[satir].Cells["AD_SOYAD"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
                txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
                txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
                dtEKLEME_TARIHI.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
                string cmb = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();

                if (cmb == "True")
                {
                    cmbDURUMU.Text = "Aktif";
                    
                }
                else if (cmb == "False")
                {
                    cmbDURUMU.Text = "Pasif";
                }
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {   // YENİ
            txtUYE_REFNO.Text = "";
            txtAD_SOYAD.Text = "";
            txtADRES.Text = "";
            txtTELEFON.Text = "";
            txtEMAIL.Text = "";
            dtEKLEME_TARIHI.Text = "";
            cmbDURUMU.Text = "";
            txtACIKLAMA.Text = "";

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {   // KAYDET

            if (txtAD_SOYAD.Text.Trim() == "")
            {
                errorProvider1.SetError(txtAD_SOYAD, "Üye adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAD_SOYAD, "");
            }

            if (txtADRES.Text.Trim() == "")
            {
                errorProvider1.SetError(txtADRES, "Adres giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtADRES, "");
            }

            if (txtTELEFON.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTELEFON, "Telefon giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTELEFON, "");
            }

            if (txtEMAIL.Text.Trim() == "")
            {
                errorProvider1.SetError(txtEMAIL, "Email giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEMAIL, "");
            }

            if (dtEKLEME_TARIHI.Text.Trim() == "")
            {
                errorProvider1.SetError(dtEKLEME_TARIHI, "Tarihi giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(dtEKLEME_TARIHI, "");
            }

            if (cmbDURUMU.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbDURUMU, "Durum giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbDURUMU, "");
            }

            UYE u = new UYE();
            if (txtUYE_REFNO.Text != "")
            {
                u = db.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                u.AD_SOYAD = txtAD_SOYAD.Text;
                u.ADRES = txtADRES.Text;
                u.TELEFON = txtTELEFON.Text;
                u.EMAIL = txtEMAIL.Text;
                u.EKLEME_TARIHI = dtEKLEME_TARIHI.Value;
                if (cmbDURUMU.Text == "Aktif")
                {
                    u.DURUMU = Convert.ToBoolean(true);
                }
                else if (cmbDURUMU.Text == "Pasif")
                {
                    u.DURUMU = Convert.ToBoolean(false);
                }
                u.ACIKLAMA = txtACIKLAMA.Text;
                db.SaveChanges();
            }
            else
            {
                u.AD_SOYAD = txtAD_SOYAD.Text;
                u.ADRES = txtADRES.Text;
                u.TELEFON = txtTELEFON.Text;
                u.EMAIL = txtEMAIL.Text;
                u.EKLEME_TARIHI = dtEKLEME_TARIHI.Value;
                if (cmbDURUMU.Text == "Aktif")
                {
                    u.DURUMU = Convert.ToBoolean(true);
                }
                else if (cmbDURUMU.Text == "Pasif")
                {
                    u.DURUMU = Convert.ToBoolean(false);
                }
                u.ACIKLAMA = txtACIKLAMA.Text;
                db.UYEs.Add(u);
                db.SaveChanges();
            }
            var liste = db.UYEs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {   // VAZGEÇ
            if (satir > -1)
            {
                txtUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                txtAD_SOYAD.Text = dataGridView1.Rows[satir].Cells["AD_SOYAD"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
                txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
                txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
                dtEKLEME_TARIHI.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
                string cmb = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
                if (cmb == "True")
                {
                    cmbDURUMU.Text = "Aktif";
                }
                if (cmb == "False")
                {
                    cmbDURUMU.Text = "Pasif";
                }
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            }

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {   // SİL

            DialogResult dr = MessageBox.Show("Üye Silinsin mi ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (txtUYE_REFNO.Text != "")
                {
                    UYE u = db.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                    db.UYEs.Remove(u);
                    db.SaveChanges();
                    var liste = db.UYEs.ToList();
                    dataGridView1.DataSource = liste;
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu" + hata.Message);
            }

        }

       
        
    }

}
