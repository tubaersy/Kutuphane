namespace KUTUPHANE
{
    partial class frmODUNC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtODUNC_KITAP_REFNO = new System.Windows.Forms.TextBox();
            this.txtACIKLAMA = new System.Windows.Forms.TextBox();
            this.cmbDURUMU = new System.Windows.Forms.ComboBox();
            this.dtVERILIS_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbUYE_REFNO = new System.Windows.Forms.ComboBox();
            this.cmbKITAP_REFNO = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtALINIS_TARIHI = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 25);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖDÜNÇ KİTAP REFNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÜYE REFNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "KİTAP REFNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "VERİLİŞ TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ALINIŞ TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DURUMU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "AÇIKLAMA";
            // 
            // txtODUNC_KITAP_REFNO
            // 
            this.txtODUNC_KITAP_REFNO.Location = new System.Drawing.Point(161, 39);
            this.txtODUNC_KITAP_REFNO.Name = "txtODUNC_KITAP_REFNO";
            this.txtODUNC_KITAP_REFNO.ReadOnly = true;
            this.txtODUNC_KITAP_REFNO.Size = new System.Drawing.Size(100, 20);
            this.txtODUNC_KITAP_REFNO.TabIndex = 9;
            // 
            // txtACIKLAMA
            // 
            this.txtACIKLAMA.Location = new System.Drawing.Point(161, 321);
            this.txtACIKLAMA.Multiline = true;
            this.txtACIKLAMA.Name = "txtACIKLAMA";
            this.txtACIKLAMA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtACIKLAMA.Size = new System.Drawing.Size(275, 108);
            this.txtACIKLAMA.TabIndex = 12;
            // 
            // cmbDURUMU
            // 
            this.cmbDURUMU.FormattingEnabled = true;
            this.cmbDURUMU.Location = new System.Drawing.Point(161, 273);
            this.cmbDURUMU.Name = "cmbDURUMU";
            this.cmbDURUMU.Size = new System.Drawing.Size(100, 21);
            this.cmbDURUMU.TabIndex = 13;
            
            // 
            // dtVERILIS_TARIHI
            // 
            this.dtVERILIS_TARIHI.Location = new System.Drawing.Point(161, 179);
            this.dtVERILIS_TARIHI.Name = "dtVERILIS_TARIHI";
            this.dtVERILIS_TARIHI.Size = new System.Drawing.Size(100, 20);
            this.dtVERILIS_TARIHI.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(366, 396);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Yeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(302, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // cmbUYE_REFNO
            // 
            this.cmbUYE_REFNO.FormattingEnabled = true;
            this.cmbUYE_REFNO.Location = new System.Drawing.Point(161, 86);
            this.cmbUYE_REFNO.Name = "cmbUYE_REFNO";
            this.cmbUYE_REFNO.Size = new System.Drawing.Size(100, 21);
            this.cmbUYE_REFNO.TabIndex = 21;
            // 
            // cmbKITAP_REFNO
            // 
            this.cmbKITAP_REFNO.FormattingEnabled = true;
            this.cmbKITAP_REFNO.Location = new System.Drawing.Point(161, 134);
            this.cmbKITAP_REFNO.Name = "cmbKITAP_REFNO";
            this.cmbKITAP_REFNO.Size = new System.Drawing.Size(100, 21);
            this.cmbKITAP_REFNO.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtALINIS_TARIHI
            // 
            this.dtALINIS_TARIHI.Location = new System.Drawing.Point(161, 225);
            this.dtALINIS_TARIHI.Name = "dtALINIS_TARIHI";
            this.dtALINIS_TARIHI.Size = new System.Drawing.Size(100, 20);
            this.dtALINIS_TARIHI.TabIndex = 24;
            // 
            // frmODUNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 476);
            this.Controls.Add(this.dtALINIS_TARIHI);
            this.Controls.Add(this.cmbKITAP_REFNO);
            this.Controls.Add(this.cmbUYE_REFNO);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtVERILIS_TARIHI);
            this.Controls.Add(this.cmbDURUMU);
            this.Controls.Add(this.txtACIKLAMA);
            this.Controls.Add(this.txtODUNC_KITAP_REFNO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmODUNC";
            this.Text = "ÖDÜNÇ KİTAP";
            this.Load += new System.EventHandler(this.FrmODUNC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtODUNC_KITAP_REFNO;
        private System.Windows.Forms.TextBox txtACIKLAMA;
        private System.Windows.Forms.ComboBox cmbDURUMU;
        private System.Windows.Forms.DateTimePicker dtVERILIS_TARIHI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbUYE_REFNO;
        private System.Windows.Forms.ComboBox cmbKITAP_REFNO;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtALINIS_TARIHI;
    }
}