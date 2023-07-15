namespace Harjoitustehtävä
{
    partial class HenkTiedot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HenkTiedot));
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEtsi = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPoista = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaivita = new System.Windows.Forms.ToolStripButton();
            this.tbEtunimet = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEtunimet = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblKutsumanimi = new System.Windows.Forms.Label();
            this.tbKutsumanimi = new System.Windows.Forms.TextBox();
            this.lblHetu = new System.Windows.Forms.Label();
            this.tbHetu = new System.Windows.Forms.TextBox();
            this.lblKotiOsoite = new System.Windows.Forms.Label();
            this.tbKotiOsoite = new System.Windows.Forms.TextBox();
            this.lblPostinum = new System.Windows.Forms.Label();
            this.tbPostinum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAlkamispv = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPaattymispv = new System.Windows.Forms.DateTimePicker();
            this.rbVoimassaOleva = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNimike = new System.Windows.Forms.TextBox();
            this.lblYksikko = new System.Windows.Forms.Label();
            this.tbYksikko = new System.Windows.Forms.TextBox();
            this.epVirhe = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlgAvaa = new System.Windows.Forms.OpenFileDialog();
            this.tbPostitmp = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgTiedot = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiedot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Henkilö tiedot";
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(514, 257);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(117, 52);
            this.btnTallenna.TabIndex = 1;
            this.btnTallenna.Text = "Tallenna tiedostoon";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEtsi,
            this.tsbtnPoista,
            this.tsbtnPaivita});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEtsi
            // 
            this.tsbEtsi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEtsi.Image = ((System.Drawing.Image)(resources.GetObject("tsbEtsi.Image")));
            this.tsbEtsi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEtsi.Name = "tsbEtsi";
            this.tsbEtsi.Size = new System.Drawing.Size(23, 22);
            this.tsbEtsi.Text = "Hae";
            this.tsbEtsi.Click += new System.EventHandler(this.tsbEtsi_Click);
            // 
            // tsbtnPoista
            // 
            this.tsbtnPoista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPoista.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPoista.Image")));
            this.tsbtnPoista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPoista.Name = "tsbtnPoista";
            this.tsbtnPoista.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPoista.Text = "Poista tiedosto";
            this.tsbtnPoista.Click += new System.EventHandler(this.tsbtnPoista_Click);
            // 
            // tsbtnPaivita
            // 
            this.tsbtnPaivita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPaivita.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPaivita.Image")));
            this.tsbtnPaivita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaivita.Name = "tsbtnPaivita";
            this.tsbtnPaivita.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPaivita.Text = "Refresh";
            this.tsbtnPaivita.Click += new System.EventHandler(this.tsbtnPaivita_Click);
            // 
            // tbEtunimet
            // 
            this.tbEtunimet.Location = new System.Drawing.Point(26, 82);
            this.tbEtunimet.Name = "tbEtunimet";
            this.tbEtunimet.Size = new System.Drawing.Size(154, 20);
            this.tbEtunimet.TabIndex = 5;
            this.tbEtunimet.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbEtunimet.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbEtunimet.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(26, 125);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 20);
            this.tbSukunimi.TabIndex = 6;
            this.tbSukunimi.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbSukunimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbSukunimi.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblStatus
            // 
            this.tslblStatus.Name = "tslblStatus";
            this.tslblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEtunimet
            // 
            this.lblEtunimet.AutoSize = true;
            this.lblEtunimet.Location = new System.Drawing.Point(23, 66);
            this.lblEtunimet.Name = "lblEtunimet";
            this.lblEtunimet.Size = new System.Drawing.Size(48, 13);
            this.lblEtunimet.TabIndex = 8;
            this.lblEtunimet.Text = "Etunimet";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(23, 109);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 9;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblKutsumanimi
            // 
            this.lblKutsumanimi.AutoSize = true;
            this.lblKutsumanimi.Location = new System.Drawing.Point(23, 153);
            this.lblKutsumanimi.Name = "lblKutsumanimi";
            this.lblKutsumanimi.Size = new System.Drawing.Size(66, 13);
            this.lblKutsumanimi.TabIndex = 10;
            this.lblKutsumanimi.Text = "Kutsumanimi";
            // 
            // tbKutsumanimi
            // 
            this.tbKutsumanimi.Location = new System.Drawing.Point(26, 169);
            this.tbKutsumanimi.Name = "tbKutsumanimi";
            this.tbKutsumanimi.Size = new System.Drawing.Size(100, 20);
            this.tbKutsumanimi.TabIndex = 11;
            this.tbKutsumanimi.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbKutsumanimi.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbKutsumanimi.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // lblHetu
            // 
            this.lblHetu.AutoSize = true;
            this.lblHetu.Location = new System.Drawing.Point(23, 197);
            this.lblHetu.Name = "lblHetu";
            this.lblHetu.Size = new System.Drawing.Size(75, 13);
            this.lblHetu.TabIndex = 12;
            this.lblHetu.Text = "Henkilötunnus";
            // 
            // tbHetu
            // 
            this.tbHetu.Location = new System.Drawing.Point(26, 213);
            this.tbHetu.Name = "tbHetu";
            this.tbHetu.Size = new System.Drawing.Size(100, 20);
            this.tbHetu.TabIndex = 13;
            this.tbHetu.Leave += new System.EventHandler(this.tbHetu_Leave);
            // 
            // lblKotiOsoite
            // 
            this.lblKotiOsoite.AutoSize = true;
            this.lblKotiOsoite.Location = new System.Drawing.Point(23, 241);
            this.lblKotiOsoite.Name = "lblKotiOsoite";
            this.lblKotiOsoite.Size = new System.Drawing.Size(53, 13);
            this.lblKotiOsoite.TabIndex = 14;
            this.lblKotiOsoite.Text = "Kotiosoite";
            // 
            // tbKotiOsoite
            // 
            this.tbKotiOsoite.Location = new System.Drawing.Point(26, 257);
            this.tbKotiOsoite.Name = "tbKotiOsoite";
            this.tbKotiOsoite.Size = new System.Drawing.Size(154, 20);
            this.tbKotiOsoite.TabIndex = 15;
            this.tbKotiOsoite.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbKotiOsoite.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbKotiOsoite.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // lblPostinum
            // 
            this.lblPostinum.AutoSize = true;
            this.lblPostinum.Location = new System.Drawing.Point(23, 285);
            this.lblPostinum.Name = "lblPostinum";
            this.lblPostinum.Size = new System.Drawing.Size(65, 13);
            this.lblPostinum.TabIndex = 16;
            this.lblPostinum.Text = "Postinumero";
            // 
            // tbPostinum
            // 
            this.tbPostinum.Location = new System.Drawing.Point(26, 301);
            this.tbPostinum.Name = "tbPostinum";
            this.tbPostinum.Size = new System.Drawing.Size(100, 20);
            this.tbPostinum.TabIndex = 17;
            this.tbPostinum.TextChanged += new System.EventHandler(this.tbPostinum_TextChanged);
            this.tbPostinum.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbPostinum.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbPostinum.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Postitoimipaikka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Toimisuhteen tiedot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Alkamispäivä";
            // 
            // dtpAlkamispv
            // 
            this.dtpAlkamispv.Location = new System.Drawing.Point(239, 81);
            this.dtpAlkamispv.Name = "dtpAlkamispv";
            this.dtpAlkamispv.Size = new System.Drawing.Size(195, 20);
            this.dtpAlkamispv.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Päättymispäivä";
            // 
            // dtpPaattymispv
            // 
            this.dtpPaattymispv.Location = new System.Drawing.Point(239, 125);
            this.dtpPaattymispv.Name = "dtpPaattymispv";
            this.dtpPaattymispv.Size = new System.Drawing.Size(195, 20);
            this.dtpPaattymispv.TabIndex = 24;
            this.dtpPaattymispv.ValueChanged += new System.EventHandler(this.dtpPaattymispv_ValueChanged);
            // 
            // rbVoimassaOleva
            // 
            this.rbVoimassaOleva.AutoSize = true;
            this.rbVoimassaOleva.Location = new System.Drawing.Point(449, 126);
            this.rbVoimassaOleva.Name = "rbVoimassaOleva";
            this.rbVoimassaOleva.Size = new System.Drawing.Size(156, 17);
            this.rbVoimassaOleva.TabIndex = 25;
            this.rbVoimassaOleva.TabStop = true;
            this.rbVoimassaOleva.Text = "Toistaiseksi voimassa oleva";
            this.rbVoimassaOleva.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Työ nimike";
            // 
            // tbNimike
            // 
            this.tbNimike.Location = new System.Drawing.Point(239, 168);
            this.tbNimike.Name = "tbNimike";
            this.tbNimike.Size = new System.Drawing.Size(100, 20);
            this.tbNimike.TabIndex = 27;
            this.tbNimike.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbNimike.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbNimike.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // lblYksikko
            // 
            this.lblYksikko.AutoSize = true;
            this.lblYksikko.Location = new System.Drawing.Point(236, 197);
            this.lblYksikko.Name = "lblYksikko";
            this.lblYksikko.Size = new System.Drawing.Size(45, 13);
            this.lblYksikko.TabIndex = 28;
            this.lblYksikko.Text = "Yksikkö";
            // 
            // tbYksikko
            // 
            this.tbYksikko.Location = new System.Drawing.Point(239, 213);
            this.tbYksikko.Name = "tbYksikko";
            this.tbYksikko.Size = new System.Drawing.Size(100, 20);
            this.tbYksikko.TabIndex = 29;
            this.tbYksikko.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            this.tbYksikko.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtunimet_Validating);
            this.tbYksikko.Validated += new System.EventHandler(this.tbEtunimet_Validated);
            // 
            // epVirhe
            // 
            this.epVirhe.ContainerControl = this;
            // 
            // dlgAvaa
            // 
            this.dlgAvaa.FileName = "dlgAvaa";
            // 
            // tbPostitmp
            // 
            this.tbPostitmp.Location = new System.Drawing.Point(26, 346);
            this.tbPostitmp.Name = "tbPostitmp";
            this.tbPostitmp.Size = new System.Drawing.Size(100, 20);
            this.tbPostitmp.TabIndex = 32;
            this.tbPostitmp.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(239, 257);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(109, 52);
            this.btnLisaa.TabIndex = 34;
            this.btnLisaa.Text = "Lisää ";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click_1);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(374, 259);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(109, 50);
            this.btnPoista.TabIndex = 35;
            this.btnPoista.Text = "Poista rivi";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgTiedot
            // 
            this.dgTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTiedot.Location = new System.Drawing.Point(26, 384);
            this.dgTiedot.MultiSelect = false;
            this.dgTiedot.Name = "dgTiedot";
            this.dgTiedot.ReadOnly = true;
            this.dgTiedot.Size = new System.Drawing.Size(657, 169);
            this.dgTiedot.TabIndex = 36;
            this.dgTiedot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTiedot_CellClick);
            this.dgTiedot.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTiedot_ColumnHeaderMouseClick);
            // 
            // HenkTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(693, 578);
            this.Controls.Add(this.dgTiedot);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbPostitmp);
            this.Controls.Add(this.tbYksikko);
            this.Controls.Add(this.lblYksikko);
            this.Controls.Add(this.tbNimike);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbVoimassaOleva);
            this.Controls.Add(this.dtpPaattymispv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpAlkamispv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPostinum);
            this.Controls.Add(this.lblPostinum);
            this.Controls.Add(this.tbKotiOsoite);
            this.Controls.Add(this.lblKotiOsoite);
            this.Controls.Add(this.tbHetu);
            this.Controls.Add(this.lblHetu);
            this.Controls.Add(this.tbKutsumanimi);
            this.Controls.Add(this.lblKutsumanimi);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimet);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimet);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.lblStatus);
            this.Name = "HenkTiedot";
            this.Text = "Henkilö tiedot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVirhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiedot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEtsi;
        private System.Windows.Forms.TextBox tbEtunimet;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblStatus;
        private System.Windows.Forms.Label lblEtunimet;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblKutsumanimi;
        private System.Windows.Forms.TextBox tbKutsumanimi;
        private System.Windows.Forms.Label lblHetu;
        private System.Windows.Forms.TextBox tbHetu;
        private System.Windows.Forms.Label lblKotiOsoite;
        private System.Windows.Forms.TextBox tbKotiOsoite;
        private System.Windows.Forms.Label lblPostinum;
        private System.Windows.Forms.TextBox tbPostinum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAlkamispv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPaattymispv;
        private System.Windows.Forms.RadioButton rbVoimassaOleva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNimike;
        private System.Windows.Forms.Label lblYksikko;
        private System.Windows.Forms.TextBox tbYksikko;
        private System.Windows.Forms.ErrorProvider epVirhe;
        private System.Windows.Forms.ToolStripButton tsbtnPoista;
        private System.Windows.Forms.OpenFileDialog dlgAvaa;
        private System.Windows.Forms.TextBox tbPostitmp;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.ToolStripButton tsbtnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgTiedot;
    }
}

