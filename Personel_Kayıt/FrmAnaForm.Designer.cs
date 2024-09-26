namespace Personel_Kayıt
{
	partial class FrmAnaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mskMaas = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.CmbSehir = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMeslek = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnGrafik = new System.Windows.Forms.Button();
			this.btnistatistik = new System.Windows.Forms.Button();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.btnGüncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personelVeriTabaniDataSet = new Personel_Kayıt.PersonelVeriTabaniDataSet();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbl_PersonelTableAdapter = new Personel_Kayıt.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mskMaas);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.CmbSehir);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMeslek);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtid);
			this.groupBox1.Controls.Add(this.txtSoyad);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtAd);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(342, 396);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Kayıt";
			// 
			// mskMaas
			// 
			this.mskMaas.Location = new System.Drawing.Point(162, 225);
			this.mskMaas.Mask = "0000";
			this.mskMaas.Name = "mskMaas";
			this.mskMaas.Size = new System.Drawing.Size(163, 36);
			this.mskMaas.TabIndex = 5;
			this.mskMaas.ValidatingType = typeof(int);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(74, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 28);
			this.label7.TabIndex = 11;
			this.label7.Text = "Maaş:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(235, 266);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(88, 32);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Bekar";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(72, 307);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 28);
			this.label6.TabIndex = 4;
			this.label6.Text = "Meslek:";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(162, 266);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(67, 32);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Evli";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(72, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 28);
			this.label5.TabIndex = 8;
			this.label5.Text = "Durum:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(74, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Şehir:";
			// 
			// CmbSehir
			// 
			this.CmbSehir.FormattingEnabled = true;
			this.CmbSehir.Location = new System.Drawing.Point(162, 183);
			this.CmbSehir.Name = "CmbSehir";
			this.CmbSehir.Size = new System.Drawing.Size(163, 36);
			this.CmbSehir.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Soyad:";
			// 
			// txtMeslek
			// 
			this.txtMeslek.Location = new System.Drawing.Point(160, 304);
			this.txtMeslek.Name = "txtMeslek";
			this.txtMeslek.Size = new System.Drawing.Size(163, 36);
			this.txtMeslek.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Personel Ad:";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(162, 42);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(163, 36);
			this.txtid.TabIndex = 0;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(162, 135);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(163, 36);
			this.txtSoyad.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personel id:";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(162, 93);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(163, 36);
			this.txtAd.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnGrafik);
			this.groupBox2.Controls.Add(this.btnistatistik);
			this.groupBox2.Controls.Add(this.btnTemizle);
			this.groupBox2.Controls.Add(this.btnGüncelle);
			this.groupBox2.Controls.Add(this.btnSil);
			this.groupBox2.Controls.Add(this.btnListele);
			this.groupBox2.Controls.Add(this.btnKaydet);
			this.groupBox2.Location = new System.Drawing.Point(421, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(322, 380);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "İşlemler";
			// 
			// btnGrafik
			// 
			this.btnGrafik.Location = new System.Drawing.Point(40, 320);
			this.btnGrafik.Name = "btnGrafik";
			this.btnGrafik.Size = new System.Drawing.Size(224, 41);
			this.btnGrafik.TabIndex = 2;
			this.btnGrafik.Text = "Grafikler";
			this.btnGrafik.UseVisualStyleBackColor = true;
			this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
			// 
			// btnistatistik
			// 
			this.btnistatistik.Location = new System.Drawing.Point(40, 273);
			this.btnistatistik.Name = "btnistatistik";
			this.btnistatistik.Size = new System.Drawing.Size(224, 41);
			this.btnistatistik.TabIndex = 2;
			this.btnistatistik.Text = "İstatistik";
			this.btnistatistik.UseVisualStyleBackColor = true;
			this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
			// 
			// btnTemizle
			// 
			this.btnTemizle.Location = new System.Drawing.Point(40, 226);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(224, 41);
			this.btnTemizle.TabIndex = 3;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = true;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// btnGüncelle
			// 
			this.btnGüncelle.Location = new System.Drawing.Point(40, 179);
			this.btnGüncelle.Name = "btnGüncelle";
			this.btnGüncelle.Size = new System.Drawing.Size(224, 41);
			this.btnGüncelle.TabIndex = 4;
			this.btnGüncelle.Text = "Güncelle";
			this.btnGüncelle.UseVisualStyleBackColor = true;
			this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(40, 132);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(224, 41);
			this.btnSil.TabIndex = 5;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(40, 38);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(224, 41);
			this.btnListele.TabIndex = 0;
			this.btnListele.Text = "Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(40, 85);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(224, 41);
			this.btnKaydet.TabIndex = 2;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(12, 455);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(932, 261);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kayıtlar";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tblPersonelBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 32);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(926, 226);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// peridDataGridViewTextBoxColumn
			// 
			this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
			this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
			this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
			this.peridDataGridViewTextBoxColumn.ReadOnly = true;
			this.peridDataGridViewTextBoxColumn.Width = 125;
			// 
			// perAdDataGridViewTextBoxColumn
			// 
			this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
			this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
			this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
			this.perAdDataGridViewTextBoxColumn.Width = 125;
			// 
			// perSoyadDataGridViewTextBoxColumn
			// 
			this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
			this.perSoyadDataGridViewTextBoxColumn.Width = 125;
			// 
			// perSehirDataGridViewTextBoxColumn
			// 
			this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
			this.perSehirDataGridViewTextBoxColumn.Width = 125;
			// 
			// perMaasDataGridViewTextBoxColumn
			// 
			this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
			this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
			this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
			this.perMaasDataGridViewTextBoxColumn.Width = 125;
			// 
			// perDurumDataGridViewCheckBoxColumn
			// 
			this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
			this.perDurumDataGridViewCheckBoxColumn.Width = 125;
			// 
			// perMeslekDataGridViewTextBoxColumn
			// 
			this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
			this.perMeslekDataGridViewTextBoxColumn.Width = 125;
			// 
			// tblPersonelBindingSource
			// 
			this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
			// 
			// personelVeriTabaniDataSet
			// 
			this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
			this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(788, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(231, 197);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// tbl_PersonelTableAdapter
			// 
			this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(798, 417);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 28);
			this.label8.TabIndex = 4;
			this.label8.Text = "label8";
			this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
			// 
			// FrmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1065, 726);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmAnaForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox CmbSehir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMeslek;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Button btnGüncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnistatistik;
		private System.Windows.Forms.MaskedTextBox mskMaas;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnGrafik;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
		private System.Windows.Forms.BindingSource tblPersonelBindingSource;
		private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label8;
	}
}

