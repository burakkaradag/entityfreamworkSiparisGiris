namespace siparisgiris
{
    partial class frmorder
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
            this.textBoxorderno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxcust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerorder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerreq = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickership = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxemp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxkargo = new System.Windows.Forms.ComboBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngünceldetay = new System.Windows.Forms.Button();
            this.btnsildetay = new System.Windows.Forms.Button();
            this.btnekledetay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxsatır = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxsiptoplam = new System.Windows.Forms.TextBox();
            this.cmbboxproduct = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxmiktar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxiskonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxorderno
            // 
            this.textBoxorderno.Enabled = false;
            this.textBoxorderno.Location = new System.Drawing.Point(28, 38);
            this.textBoxorderno.Name = "textBoxorderno";
            this.textBoxorderno.Size = new System.Drawing.Size(56, 20);
            this.textBoxorderno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sipariş";
            // 
            // comboBoxcust
            // 
            this.comboBoxcust.FormattingEnabled = true;
            this.comboBoxcust.Location = new System.Drawing.Point(90, 36);
            this.comboBoxcust.Name = "comboBoxcust";
            this.comboBoxcust.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcust.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri";
            // 
            // dateTimePickerorder
            // 
            this.dateTimePickerorder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerorder.Location = new System.Drawing.Point(212, 36);
            this.dateTimePickerorder.Name = "dateTimePickerorder";
            this.dateTimePickerorder.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerorder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sipariş Tarihi";
            // 
            // dateTimePickerreq
            // 
            this.dateTimePickerreq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerreq.Location = new System.Drawing.Point(313, 35);
            this.dateTimePickerreq.Name = "dateTimePickerreq";
            this.dateTimePickerreq.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerreq.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Son Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gönderi Tarihi";
            // 
            // dateTimePickership
            // 
            this.dateTimePickership.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickership.Location = new System.Drawing.Point(416, 35);
            this.dateTimePickership.Name = "dateTimePickership";
            this.dateTimePickership.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickership.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Satıcı";
            // 
            // comboBoxemp
            // 
            this.comboBoxemp.FormattingEnabled = true;
            this.comboBoxemp.Location = new System.Drawing.Point(528, 34);
            this.comboBoxemp.Name = "comboBoxemp";
            this.comboBoxemp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxemp.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kargo Şirketi";
            // 
            // comboBoxkargo
            // 
            this.comboBoxkargo.FormattingEnabled = true;
            this.comboBoxkargo.Location = new System.Drawing.Point(660, 34);
            this.comboBoxkargo.Name = "comboBoxkargo";
            this.comboBoxkargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxkargo.TabIndex = 13;
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(8, 63);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 14;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(100, 63);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btngünceldetay
            // 
            this.btngünceldetay.Location = new System.Drawing.Point(8, 287);
            this.btngünceldetay.Name = "btngünceldetay";
            this.btngünceldetay.Size = new System.Drawing.Size(75, 23);
            this.btngünceldetay.TabIndex = 17;
            this.btngünceldetay.Text = "güncelle";
            this.btngünceldetay.UseVisualStyleBackColor = true;
            this.btngünceldetay.Click += new System.EventHandler(this.btngünceldetay_Click);
            // 
            // btnsildetay
            // 
            this.btnsildetay.Location = new System.Drawing.Point(749, 190);
            this.btnsildetay.Name = "btnsildetay";
            this.btnsildetay.Size = new System.Drawing.Size(75, 23);
            this.btnsildetay.TabIndex = 18;
            this.btnsildetay.Text = "sil";
            this.btnsildetay.UseVisualStyleBackColor = true;
            this.btnsildetay.Click += new System.EventHandler(this.btnsildetay_Click);
            // 
            // btnekledetay
            // 
            this.btnekledetay.Location = new System.Drawing.Point(830, 190);
            this.btnekledetay.Name = "btnekledetay";
            this.btnekledetay.Size = new System.Drawing.Size(75, 23);
            this.btnekledetay.TabIndex = 19;
            this.btnekledetay.Tag = "";
            this.btnekledetay.Text = "ekle";
            this.btnekledetay.UseVisualStyleBackColor = true;
            this.btnekledetay.Click += new System.EventHandler(this.btnekledetay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "toplam";
            // 
            // txtboxsatır
            // 
            this.txtboxsatır.Enabled = false;
            this.txtboxsatır.Location = new System.Drawing.Point(56, 258);
            this.txtboxsatır.Name = "txtboxsatır";
            this.txtboxsatır.Size = new System.Drawing.Size(56, 20);
            this.txtboxsatır.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "satır";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "siparis toplamı";
            // 
            // txtboxsiptoplam
            // 
            this.txtboxsiptoplam.Enabled = false;
            this.txtboxsiptoplam.Location = new System.Drawing.Point(511, 262);
            this.txtboxsiptoplam.Name = "txtboxsiptoplam";
            this.txtboxsiptoplam.Size = new System.Drawing.Size(138, 20);
            this.txtboxsiptoplam.TabIndex = 24;
            // 
            // cmbboxproduct
            // 
            this.cmbboxproduct.FormattingEnabled = true;
            this.cmbboxproduct.Location = new System.Drawing.Point(804, 83);
            this.cmbboxproduct.Name = "cmbboxproduct";
            this.cmbboxproduct.Size = new System.Drawing.Size(121, 21);
            this.cmbboxproduct.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(757, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "ürün";
            // 
            // txtboxmiktar
            // 
            this.txtboxmiktar.Location = new System.Drawing.Point(804, 110);
            this.txtboxmiktar.Name = "txtboxmiktar";
            this.txtboxmiktar.Size = new System.Drawing.Size(121, 20);
            this.txtboxmiktar.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(757, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "miktar";
            // 
            // txtboxiskonto
            // 
            this.txtboxiskonto.Location = new System.Drawing.Point(804, 137);
            this.txtboxiskonto.Name = "txtboxiskonto";
            this.txtboxiskonto.Size = new System.Drawing.Size(121, 20);
            this.txtboxiskonto.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(757, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "iskonto";
            // 
            // frmorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtboxiskonto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtboxmiktar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbboxproduct);
            this.Controls.Add(this.txtboxsiptoplam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtboxsatır);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnekledetay);
            this.Controls.Add(this.btnsildetay);
            this.Controls.Add(this.btngünceldetay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.comboBoxkargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickership);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerreq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxcust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxorderno);
            this.Name = "frmorder";
            this.Text = "frmorder";
            this.Load += new System.EventHandler(this.frmorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxorderno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxcust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerreq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickership;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxkargo;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngünceldetay;
        private System.Windows.Forms.Button btnsildetay;
        private System.Windows.Forms.Button btnekledetay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxsatır;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtboxsiptoplam;
        private System.Windows.Forms.ComboBox cmbboxproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxmiktar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxiskonto;
        private System.Windows.Forms.Label label13;
    }
}