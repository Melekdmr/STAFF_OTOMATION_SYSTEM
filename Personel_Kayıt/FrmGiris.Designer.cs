namespace Personel_Kayıt
{
	partial class FrmGiris
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_kullaniciad = new System.Windows.Forms.TextBox();
			this.txtsifre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btngiris = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre:";
			// 
			// txt_kullaniciad
			// 
			this.txt_kullaniciad.Location = new System.Drawing.Point(243, 106);
			this.txt_kullaniciad.Name = "txt_kullaniciad";
			this.txt_kullaniciad.Size = new System.Drawing.Size(192, 34);
			this.txt_kullaniciad.TabIndex = 2;
			// 
			// txtsifre
			// 
			this.txtsifre.Location = new System.Drawing.Point(243, 155);
			this.txtsifre.Name = "txtsifre";
			this.txtsifre.Size = new System.Drawing.Size(192, 34);
			this.txtsifre.TabIndex = 3;
			this.txtsifre.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(50, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(459, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
			// 
			// btngiris
			// 
			this.btngiris.Location = new System.Drawing.Point(243, 214);
			this.btngiris.Name = "btngiris";
			this.btngiris.Size = new System.Drawing.Size(192, 38);
			this.btngiris.TabIndex = 5;
			this.btngiris.Text = "Giriş Yap";
			this.btngiris.UseVisualStyleBackColor = true;
			this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(571, 389);
			this.Controls.Add(this.btngiris);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtsifre);
			this.Controls.Add(this.txt_kullaniciad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "FrmGiris";
			this.Text = "FrmGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_kullaniciad;
		private System.Windows.Forms.TextBox txtsifre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btngiris;
	}
}