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
    public partial class frmKITAP : Form
    {
        KUTUPHANEEntities6 db = new KUTUPHANEEntities6();
        int satir = -1;

        public frmKITAP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var liste = db.KITAPs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dtBASIM_TARIHI.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtOZET.Text = dataGridView1.Rows[satir].Cells["OZET"].Value.ToString();
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {   // YENİ
            txtKITAP_REFNO.Text = "";
            txtADI.Text = "";
            txtISBN.Text = "";
            txtYAZARI.Text = "";
            dtBASIM_TARIHI.Text = "";
            txtYAYIN_EVI.Text = "";
            txtOZET.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {   // KAYDET

            if (txtADI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtADI, "Kitap adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtADI, "");
            }

            if (txtISBN.Text.Trim() == "")
            {
                errorProvider1.SetError(txtISBN, "ISBN giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtISBN, "");
            }

            if (txtYAZARI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtYAZARI, "Yazar adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtYAZARI, "");
            }

            if (dtBASIM_TARIHI.Text.Trim() == "")
            {
                errorProvider1.SetError(dtBASIM_TARIHI, "Basım tarihi giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(dtBASIM_TARIHI, "");
            }

            if (txtYAYIN_EVI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtYAYIN_EVI, "Yayınevi giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtYAYIN_EVI, "");
            }


            KITAP k = new KITAP();
            if (txtKITAP_REFNO.Text != "")
            {
                k = db.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                k.ADI = txtADI.Text;
                k.ISBN = txtISBN.Text;
                k.YAZARI = txtYAZARI.Text;
                k.BASIM_TARIHI = dtBASIM_TARIHI.Value;
                k.YAYIN_EVI = txtYAYIN_EVI.Text;
                k.OZET = txtOZET.Text;
                db.SaveChanges();
            }
            else
            {
                k.ADI = txtADI.Text;
                k.ISBN = txtISBN.Text;
                k.YAZARI = txtYAZARI.Text;
                k.BASIM_TARIHI = dtBASIM_TARIHI.Value;
                k.YAYIN_EVI = txtYAYIN_EVI.Text;
                k.OZET = txtOZET.Text;
                db.KITAPs.Add(k);
                db.SaveChanges();
            }
            var liste = db.KITAPs.ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button3_Click(object sender, EventArgs e)
        {   // VAZGEÇ
            if (satir > -1)
            {
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dtBASIM_TARIHI.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtOZET.Text = dataGridView1.Rows[satir].Cells["OZET"].Value.ToString();

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {   // SİL

            DialogResult dr = MessageBox.Show("Kitap Silinsin mi ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (txtKITAP_REFNO.Text != "")
                {

                    KITAP k = db.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                    db.KITAPs.Remove(k);
                    db.SaveChanges();
                    var liste = db.KITAPs.ToList();
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
