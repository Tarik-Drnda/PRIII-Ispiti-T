namespace DLWMS.WinForms.IB220069
{
    partial class frmStudentSeminarskiIB220069
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
            lblImePrezime = new Label();
            lblPredmet = new Label();
            grpNoviSeminarski = new GroupBox();
            btnDodajSliku = new Button();
            txtOpis = new TextBox();
            lblOpisNovi = new Label();
            pcbNoviSlika = new PictureBox();
            lblSlika = new Label();
            grpPregledSeminarskog = new GroupBox();
            lblOpis = new Label();
            lblDatum = new Label();
            btnLijevoSlika = new Button();
            btnDesnoSlika = new Button();
            pcbSlikaSeminarskog = new PictureBox();
            lblStranicaBroj = new Label();
            ofdSlikaSeminarskog = new OpenFileDialog();
            errSeminarski = new ErrorProvider(components);
            grpNoviSeminarski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNoviSlika).BeginInit();
            grpPregledSeminarskog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSlikaSeminarskog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSeminarski).BeginInit();
            SuspendLayout();
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblImePrezime.Location = new Point(194, 10);
            lblImePrezime.Margin = new Padding(4, 0, 4, 0);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(110, 24);
            lblImePrezime.TabIndex = 0;
            lblImePrezime.Text = "ImePrezime";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPredmet.Location = new Point(194, 48);
            lblPredmet.Margin = new Padding(4, 0, 4, 0);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(81, 24);
            lblPredmet.TabIndex = 1;
            lblPredmet.Text = "Predmet";
            // 
            // grpNoviSeminarski
            // 
            grpNoviSeminarski.Controls.Add(btnDodajSliku);
            grpNoviSeminarski.Controls.Add(txtOpis);
            grpNoviSeminarski.Controls.Add(lblOpisNovi);
            grpNoviSeminarski.Controls.Add(pcbNoviSlika);
            grpNoviSeminarski.Controls.Add(lblSlika);
            grpNoviSeminarski.Location = new Point(14, 95);
            grpNoviSeminarski.Margin = new Padding(4, 3, 4, 3);
            grpNoviSeminarski.Name = "grpNoviSeminarski";
            grpNoviSeminarski.Padding = new Padding(4, 3, 4, 3);
            grpNoviSeminarski.Size = new Size(492, 192);
            grpNoviSeminarski.TabIndex = 2;
            grpNoviSeminarski.TabStop = false;
            grpNoviSeminarski.Text = "Novi Seminarski";
            // 
            // btnDodajSliku
            // 
            btnDodajSliku.Location = new Point(398, 158);
            btnDodajSliku.Margin = new Padding(4, 3, 4, 3);
            btnDodajSliku.Name = "btnDodajSliku";
            btnDodajSliku.Size = new Size(88, 27);
            btnDodajSliku.TabIndex = 4;
            btnDodajSliku.Text = "Dodaj sliku";
            btnDodajSliku.UseVisualStyleBackColor = true;
            btnDodajSliku.Click += btnDodajSliku_Click;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(191, 51);
            txtOpis.Margin = new Padding(4, 3, 4, 3);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(293, 82);
            txtOpis.TabIndex = 3;
            // 
            // lblOpisNovi
            // 
            lblOpisNovi.AutoSize = true;
            lblOpisNovi.Location = new Point(200, 32);
            lblOpisNovi.Margin = new Padding(4, 0, 4, 0);
            lblOpisNovi.Name = "lblOpisNovi";
            lblOpisNovi.Size = new Size(34, 15);
            lblOpisNovi.TabIndex = 2;
            lblOpisNovi.Text = "Opis:";
            // 
            // pcbNoviSlika
            // 
            pcbNoviSlika.Location = new Point(21, 51);
            pcbNoviSlika.Margin = new Padding(4, 3, 4, 3);
            pcbNoviSlika.Name = "pcbNoviSlika";
            pcbNoviSlika.Size = new Size(117, 134);
            pcbNoviSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbNoviSlika.TabIndex = 1;
            pcbNoviSlika.TabStop = false;
            pcbNoviSlika.DoubleClick += pcbNoviSlika_DoubleClick;
            // 
            // lblSlika
            // 
            lblSlika.AutoSize = true;
            lblSlika.Location = new Point(18, 32);
            lblSlika.Margin = new Padding(4, 0, 4, 0);
            lblSlika.Name = "lblSlika";
            lblSlika.Size = new Size(34, 15);
            lblSlika.TabIndex = 0;
            lblSlika.Text = "Slika:";
            // 
            // grpPregledSeminarskog
            // 
            grpPregledSeminarskog.Controls.Add(lblOpis);
            grpPregledSeminarskog.Controls.Add(lblDatum);
            grpPregledSeminarskog.Controls.Add(btnLijevoSlika);
            grpPregledSeminarskog.Controls.Add(btnDesnoSlika);
            grpPregledSeminarskog.Controls.Add(pcbSlikaSeminarskog);
            grpPregledSeminarskog.Controls.Add(lblStranicaBroj);
            grpPregledSeminarskog.Location = new Point(14, 293);
            grpPregledSeminarskog.Margin = new Padding(4, 3, 4, 3);
            grpPregledSeminarskog.Name = "grpPregledSeminarskog";
            grpPregledSeminarskog.Padding = new Padding(4, 3, 4, 3);
            grpPregledSeminarskog.Size = new Size(485, 486);
            grpPregledSeminarskog.TabIndex = 3;
            grpPregledSeminarskog.TabStop = false;
            grpPregledSeminarskog.Text = "Pregled Seminarskog";
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(21, 404);
            lblOpis.Margin = new Padding(4, 0, 4, 0);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(31, 15);
            lblOpis.TabIndex = 5;
            lblOpis.Text = "Opis";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(200, 339);
            lblDatum.Margin = new Padding(4, 0, 4, 0);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(43, 15);
            lblDatum.TabIndex = 4;
            lblDatum.Text = "Datum";
            // 
            // btnLijevoSlika
            // 
            btnLijevoSlika.Location = new Point(7, 175);
            btnLijevoSlika.Margin = new Padding(4, 3, 4, 3);
            btnLijevoSlika.Name = "btnLijevoSlika";
            btnLijevoSlika.Size = new Size(102, 45);
            btnLijevoSlika.TabIndex = 3;
            btnLijevoSlika.Text = "<==";
            btnLijevoSlika.UseVisualStyleBackColor = true;
            btnLijevoSlika.Click += btnLijevoSlika_Click;
            // 
            // btnDesnoSlika
            // 
            btnDesnoSlika.Location = new Point(376, 175);
            btnDesnoSlika.Margin = new Padding(4, 3, 4, 3);
            btnDesnoSlika.Name = "btnDesnoSlika";
            btnDesnoSlika.Size = new Size(99, 45);
            btnDesnoSlika.TabIndex = 2;
            btnDesnoSlika.Text = "==>";
            btnDesnoSlika.UseVisualStyleBackColor = true;
            btnDesnoSlika.Click += btnDesnoSlika_Click;
            // 
            // pcbSlikaSeminarskog
            // 
            pcbSlikaSeminarskog.Location = new Point(115, 89);
            pcbSlikaSeminarskog.Margin = new Padding(4, 3, 4, 3);
            pcbSlikaSeminarskog.Name = "pcbSlikaSeminarskog";
            pcbSlikaSeminarskog.Size = new Size(253, 247);
            pcbSlikaSeminarskog.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSlikaSeminarskog.TabIndex = 1;
            pcbSlikaSeminarskog.TabStop = false;
            // 
            // lblStranicaBroj
            // 
            lblStranicaBroj.AutoSize = true;
            lblStranicaBroj.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStranicaBroj.Location = new Point(184, 46);
            lblStranicaBroj.Margin = new Padding(4, 0, 4, 0);
            lblStranicaBroj.Name = "lblStranicaBroj";
            lblStranicaBroj.Size = new Size(77, 24);
            lblStranicaBroj.TabIndex = 0;
            lblStranicaBroj.Text = "Stranica";
            // 
            // ofdSlikaSeminarskog
            // 
            ofdSlikaSeminarskog.FileName = "SlikaSeminarskog";
            // 
            // errSeminarski
            // 
            errSeminarski.ContainerControl = this;
            // 
            // frmStudentSeminarskiIB220069
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 793);
            Controls.Add(grpPregledSeminarskog);
            Controls.Add(grpNoviSeminarski);
            Controls.Add(lblPredmet);
            Controls.Add(lblImePrezime);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentSeminarskiIB220069";
            Text = "frmStudentSeminarskiIB220069";
            Load += frmStudentSeminarskiIB220069_Load;
            grpNoviSeminarski.ResumeLayout(false);
            grpNoviSeminarski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbNoviSlika).EndInit();
            grpPregledSeminarskog.ResumeLayout(false);
            grpPregledSeminarskog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSlikaSeminarskog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSeminarski).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.GroupBox grpNoviSeminarski;
        private System.Windows.Forms.PictureBox pcbNoviSlika;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpisNovi;
        private System.Windows.Forms.GroupBox grpPregledSeminarskog;
        private System.Windows.Forms.PictureBox pcbSlikaSeminarskog;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnLijevoSlika;
        private System.Windows.Forms.Button btnDesnoSlika;
        private System.Windows.Forms.OpenFileDialog ofdSlikaSeminarskog;
        private System.Windows.Forms.ErrorProvider errSeminarski;
        private Label lblStranicaBroj;
    }
}