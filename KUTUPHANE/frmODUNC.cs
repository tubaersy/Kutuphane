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
    public partial class frmODUNC : Form
    {
        KUTUPHANEEntities6 db = new KUTUPHANEEntities6();
        int satir = -1;
        public frmODUNC()
        {
            InitializeComponent();
        }

        private void FrmODUNC_Load(object sender, EventArgs e)
        {
            var liste = db.ODUNC_KITAP.ToList();
            var liste2 = db.KITAPs.ToList();
            var liste3 = db.UYEs.ToList();
            dataGridView1.DataSource = liste;
            cmbDURUMU.Items.Add("Verildi");
            cmbDURUMU.Items.Add("Alındı");

            cmbKITAP_REFNO.DisplayMember = "Text";
            
            foreach (var i in liste2)
            {
                cmbKITAP_REFNO.Items.Add(new { Text = i.KITAP_REFNO});
            }

            cmbUYE_REFNO.DisplayMember = "Text";

            foreach (var i in liste3)
            {
                cmbUYE_REFNO.Items.Add(new { Text = i.AD_SOYAD});
            }

            
            
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtODUNC_KITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value.ToString();
                cmbUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                cmbKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                dtVERILIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value.ToString();
                string cmb = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
                if (cmb == "True")
                {
                    cmbDURUMU.Text = "Alındı";
                    dtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
                }
                else if (cmb == "False")
                {
                    cmbDURUMU.Text = "Verildi";
                    dtALINIS_TARIHI.Text = null;
                }

                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {   // YENİ

            txtODUNC_KITAP_REFNO.Text = "";
            cmbUYE_REFNO.Text = "";
            cmbKITAP_REFNO.Text = "";
            dtVERILIS_TARIHI.Text = "";
            dtALINIS_TARIHI.Text = "";
            cmbDURUMU.Text = "";
            txtACIKLAMA.Text = "";
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {   // KAYDET
            if (cmbUYE_REFNO.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbUYE_REFNO, "Üye refno giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbUYE_REFNO, "");
            }

            if (cmbKITAP_REFNO.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbKITAP_REFNO, "Kitap refno giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbKITAP_REFNO, "");
            }

            if (dtVERILIS_TARIHI.Text.Trim() == "")
            {
                errorProvider1.SetError(dtVERILIS_TARIHI, "Veriliş tarihi giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(dtVERILIS_TARIHI, "");
            }

            if (cmbDURUMU.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbDURUMU, "Durumunu giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbDURUMU, "");
            }

            ODUNC_KITAP ok = new ODUNC_KITAP();
            if (txtODUNC_KITAP_REFNO.Text != "")
            {
                ok = db.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));
                ok.UYE_REFNO = cmbUYE_REFNO.Text;
                ok.KITAP_REFNO = Convert.ToInt32(cmbKITAP_REFNO.Text);
                ok.VERILIS_TARIHI = DateTime.Parse(dtVERILIS_TARIHI.Text);
               // ok.ALINIS_TARIHI = dtALINIS_TARIHI.Text;
                
                if (cmbDURUMU.Text == "Alındı")
                {
                    ok.DURUMU = Convert.ToBoolean(true);
                    ok.ALINIS_TARIHI = DateTime.Parse(dtALINIS_TARIHI.Text);

                }
                else if (cmbDURUMU.Text == "Verildi")
                {
                    ok.DURUMU = Convert.ToBoolean(false);
                    dtALINIS_TARIHI.Text = null;

                }
                ok.ACIKLAMA = txtACIKLAMA.Text;
                db.SaveChanges();
            }
            else
            {
                ok.UYE_REFNO = cmbUYE_REFNO.Text;
                ok.KITAP_REFNO = Convert.ToInt32(cmbKITAP_REFNO.Text);
                ok.VERILIS_TARIHI = DateTime.Parse(dtVERILIS_TARIHI.Text);
                

                if (cmbDURUMU.Text == "Alındı")
                {
                    ok.DURUMU = Convert.ToBoolean(true);
                    ok.ALINIS_TARIHI = DateTime.Parse(dtALINIS_TARIHI.Text);
                }
                else if (cmbDURUMU.Text == "Verildi")
                {
                    ok.DURUMU = Convert.ToBoolean(false);
                    dtALINIS_TARIHI.Text = null;
                }
                ok.ACIKLAMA = txtACIKLAMA.Text;
                db.ODUNC_KITAP.Add(ok);
                db.SaveChanges();
            }
            var liste = db.ODUNC_KITAP.ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button3_Click(object sender, EventArgs e)
        {   // VAZGEÇ

            if (satir > -1)
            {
                txtODUNC_KITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value.ToString();
                cmbUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                cmbKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                dtVERILIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value.ToString();
                string cmb = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
                if (cmb == "True")
                {
                    cmbDURUMU.Text = "Alındı";
                    dtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
                }
                else if (cmb == "False")
                {
                    cmbDURUMU.Text = "Verildi";
                    dtALINIS_TARIHI.Text = null;
                }

                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {   // SİL


            DialogResult dr = MessageBox.Show("Ödün Verilen Kitap Silinsin mi ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (txtODUNC_KITAP_REFNO.Text != "")
                {
                    ODUNC_KITAP ok = db.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));
                    db.ODUNC_KITAP.Remove(ok);
                    db.SaveChanges();
                    var liste = db.ODUNC_KITAP.ToList();
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
