using System;
using System.Windows.Forms;

namespace KURSPROJESON
{
    partial class Form2
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
            this.AdSoyad = new System.Windows.Forms.Label();
            this.TelNo = new System.Windows.Forms.Label();
            this.MailAdres = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtMailAdres = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdSoyad
            // 
            this.AdSoyad.AutoSize = true;
            this.AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyad.Location = new System.Drawing.Point(43, 121);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(78, 20);
            this.AdSoyad.TabIndex = 1;
            this.AdSoyad.Text = "Ad Soyad";
            // 
            // TelNo
            // 
            this.TelNo.AutoSize = true;
            this.TelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelNo.Location = new System.Drawing.Point(44, 158);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(54, 20);
            this.TelNo.TabIndex = 2;
            this.TelNo.Text = "Tel No";
            // 
            // MailAdres
            // 
            this.MailAdres.AutoSize = true;
            this.MailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailAdres.Location = new System.Drawing.Point(44, 195);
            this.MailAdres.Name = "MailAdres";
            this.MailAdres.Size = new System.Drawing.Size(83, 20);
            this.MailAdres.TabIndex = 3;
            this.MailAdres.Text = "Mail Adres";
            this.MailAdres.Click += new System.EventHandler(this.label3_Click);
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adres.Location = new System.Drawing.Point(49, 234);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(51, 20);
            this.Adres.TabIndex = 4;
            this.Adres.Text = "Adres";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(127, 121);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(149, 20);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(127, 158);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(149, 20);
            this.txtTelNo.TabIndex = 6;
            // 
            // txtMailAdres
            // 
            this.txtMailAdres.Location = new System.Drawing.Point(127, 195);
            this.txtMailAdres.Name = "txtMailAdres";
            this.txtMailAdres.Size = new System.Drawing.Size(149, 20);
            this.txtMailAdres.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(127, 231);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(149, 52);
            this.txtAdres.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 162);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnGec
            // 
            this.btnGec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGec.ForeColor = System.Drawing.Color.SlateGray;
            this.btnGec.Location = new System.Drawing.Point(617, 315);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(90, 49);
            this.btnGec.TabIndex = 13;
            this.btnGec.Text = "SAYFAYI ATLA";
            this.btnGec.UseVisualStyleBackColor = false;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KURSPROJESON.Properties.Resources.sürücükurs;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SlateGray;
            this.btnUpdate.Location = new System.Drawing.Point(170, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 49);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 91);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(149, 20);
            this.txtID.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.SlateGray;
            this.btnAdd.Location = new System.Drawing.Point(48, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 49);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Kayıt Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 376);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMailAdres);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.MailAdres);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "KURS ANA EKRAN";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
       
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdSoyad;
        private System.Windows.Forms.Label TelNo;
        private System.Windows.Forms.Label MailAdres;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtMailAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnUpdate;
        private Label label1;
        private TextBox txtID;
        private Button btnAdd;
    }
}