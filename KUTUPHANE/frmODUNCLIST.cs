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
    public partial class frmODUNCLIST : Form
    {
        KUTUPHANEEntities6 db = new KUTUPHANEEntities6();


        int ToplamSatir = 0;
        int SayfadakiSatir = 10;
        int ToplamSayfa = 0;
        int AktifSayfa = 1;


        public frmODUNCLIST()
        {
            InitializeComponent();
        }

        void Sorgula(int aktifsayfa)
        {
            var liste = db.ODUNC_KITAP.Join(db.KITAPs,
                                          o => o.KITAP_REFNO,
                                          k => k.KITAP_REFNO,
                                          (o, k) => new { k.ADI, o.UYE_REFNO, k.ISBN, o.VERILIS_TARIHI, o.KITAP_REFNO, o.DURUMU})
                                          .OrderBy(o => o.KITAP_REFNO).Where(o => o.DURUMU == false)
                                          .Skip((aktifsayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList(); 

            dataGridView1.DataSource = liste.ToList();

            dataGridView1.Columns[0].HeaderText = "Kitap Adı";
            dataGridView1.Columns[1].HeaderText = "Üye adı";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void FrmODUNCLIST_Load(object sender, EventArgs e)
        {

            ToplamSatir = db.ODUNC_KITAP.Count();

            ToplamSayfa = ToplamSatir / SayfadakiSatir;

            if (ToplamSatir % SayfadakiSatir != 0)
            {
                ToplamSayfa++;
            }

            Sorgula(AktifSayfa);

            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            try
            {
                worksheet = workbook.Sheets["Sheet1"];
            }
            catch (Exception)
            {
                worksheet = workbook.Sheets["Sayfa1"];

            }

            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;    // başlıkları oluşturdu
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            // workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            // app.Quit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {   // İLK SAYFA

            Sorgula(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {   // GERİ

            if (AktifSayfa >1)
            {
                AktifSayfa--;

                Sorgula(AktifSayfa);
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {   // İLERİ

            if (AktifSayfa < ToplamSayfa)
            {
                AktifSayfa++;
                Sorgula(AktifSayfa);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {   // SON SAYFA

            AktifSayfa = ToplamSayfa;
            Sorgula(AktifSayfa);

        }
    }
}
