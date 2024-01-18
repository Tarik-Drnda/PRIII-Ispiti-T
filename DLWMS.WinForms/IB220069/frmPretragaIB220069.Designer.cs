namespace DLWMS.WinForms.IB220069
{
    partial class frmPretragaIB220069
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
            components = new System.ComponentModel.Container();
            lblMinimalnaOcjena = new Label();
            cmbOcjene = new ComboBox();
            btnPretraga = new Button();
            dgvListaStudenata = new DataGridView();
            Rb = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Seminarski = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            grpDodavanjePolozenih = new GroupBox();
            rtbInfo = new RichTextBox();
            lblInfo = new Label();
            btnDodaj = new Button();
            cmbStudenti = new ComboBox();
            lblStudent = new Label();
            txtBrojOcjena = new TextBox();
            lblBrojOcjena = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvListaStudenata).BeginInit();
            grpDodavanjePolozenih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMinimalnaOcjena
            // 
            lblMinimalnaOcjena.AutoSize = true;
            lblMinimalnaOcjena.Location = new Point(15, 35);
            lblMinimalnaOcjena.Margin = new Padding(4, 0, 4, 0);
            lblMinimalnaOcjena.Name = "lblMinimalnaOcjena";
            lblMinimalnaOcjena.Size = new Size(108, 15);
            lblMinimalnaOcjena.TabIndex = 0;
            lblMinimalnaOcjena.Text = "Minimalna ocjena: ";
            // 
            // cmbOcjene
            // 
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjene.Location = new Point(133, 31);
            cmbOcjene.Margin = new Padding(4, 3, 4, 3);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(193, 23);
            cmbOcjene.TabIndex = 1;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(334, 31);
            btnPretraga.Margin = new Padding(4, 3, 4, 3);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(122, 27);
            btnPretraga.TabIndex = 2;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // dgvListaStudenata
            // 
            dgvListaStudenata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaStudenata.Columns.AddRange(new DataGridViewColumn[] { Rb, ImePrezime, Predmet, DatumPolaganja, Ocjena, Seminarski });
            dgvListaStudenata.Location = new Point(14, 62);
            dgvListaStudenata.Margin = new Padding(4, 3, 4, 3);
            dgvListaStudenata.Name = "dgvListaStudenata";
            dgvListaStudenata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaStudenata.Size = new Size(905, 173);
            dgvListaStudenata.TabIndex = 3;
            dgvListaStudenata.CellContentClick += dgvListaStudenata_CellContentClick;
            // 
            // Rb
            // 
            Rb.DataPropertyName = "Rb";
            Rb.HeaderText = "Rb";
            Rb.Name = "Rb";
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i Prezime";
            ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            // 
            // Seminarski
            // 
            Seminarski.HeaderText = "";
            Seminarski.Name = "Seminarski";
            Seminarski.Text = "Seminarski";
            Seminarski.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(832, 242);
            btnPrintaj.Margin = new Padding(4, 3, 4, 3);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(88, 27);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // grpDodavanjePolozenih
            // 
            grpDodavanjePolozenih.Controls.Add(rtbInfo);
            grpDodavanjePolozenih.Controls.Add(lblInfo);
            grpDodavanjePolozenih.Controls.Add(btnDodaj);
            grpDodavanjePolozenih.Controls.Add(cmbStudenti);
            grpDodavanjePolozenih.Controls.Add(lblStudent);
            grpDodavanjePolozenih.Controls.Add(txtBrojOcjena);
            grpDodavanjePolozenih.Controls.Add(lblBrojOcjena);
            grpDodavanjePolozenih.Location = new Point(15, 256);
            grpDodavanjePolozenih.Name = "grpDodavanjePolozenih";
            grpDodavanjePolozenih.Size = new Size(719, 226);
            grpDodavanjePolozenih.TabIndex = 5;
            grpDodavanjePolozenih.TabStop = false;
            grpDodavanjePolozenih.Text = "Dodavanje polozenih";
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(218, 49);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(483, 161);
            rtbInfo.TabIndex = 6;
            rtbInfo.Text = "";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(218, 31);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(31, 15);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Info:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(76, 146);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 30);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbStudenti
            // 
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(6, 102);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(145, 23);
            cmbStudenti.TabIndex = 3;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(6, 84);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(48, 15);
            lblStudent.TabIndex = 2;
            lblStudent.Text = "Student";
            // 
            // txtBrojOcjena
            // 
            txtBrojOcjena.Location = new Point(6, 49);
            txtBrojOcjena.Name = "txtBrojOcjena";
            txtBrojOcjena.Size = new Size(145, 23);
            txtBrojOcjena.TabIndex = 1;
            // 
            // lblBrojOcjena
            // 
            lblBrojOcjena.AutoSize = true;
            lblBrojOcjena.Location = new Point(6, 31);
            lblBrojOcjena.Name = "lblBrojOcjena";
            lblBrojOcjena.Size = new Size(69, 15);
            lblBrojOcjena.TabIndex = 0;
            lblBrojOcjena.Text = "Broj ocjena:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPretragaIB220069
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(grpDodavanjePolozenih);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvListaStudenata);
            Controls.Add(btnPretraga);
            Controls.Add(cmbOcjene);
            Controls.Add(lblMinimalnaOcjena);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPretragaIB220069";
            Text = "frmPretragaIB220069";
            Load += frmPretragaIB220069_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaStudenata).EndInit();
            grpDodavanjePolozenih.ResumeLayout(false);
            grpDodavanjePolozenih.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMinimalnaOcjena;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvListaStudenata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Seminarski;
        private System.Windows.Forms.Button btnPrintaj;
        private GroupBox grpDodavanjePolozenih;
        private RichTextBox rtbInfo;
        private Label lblInfo;
        private Button btnDodaj;
        private ComboBox cmbStudenti;
        private Label lblStudent;
        private TextBox txtBrojOcjena;
        private Label lblBrojOcjena;
        private ErrorProvider errorProvider1;
    }
}