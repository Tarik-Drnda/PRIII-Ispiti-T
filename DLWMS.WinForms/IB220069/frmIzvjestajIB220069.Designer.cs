using Microsoft.Reporting.WinForms;
namespace DLWMS.WinForms.IB220069
{
    partial class frmIzvjestajIB220069
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
            reportViewer1 = new ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.Reports.rptPotvrda.rdlc";
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(933, 519);
            reportViewer1.TabIndex = 0;
            // 
            // frmIzvjestajIB220069
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(reportViewer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmIzvjestajIB220069";
            Text = "frmIzvjestajIB220069";
            Load += frmIzvjestajIB220069_Load;
            ResumeLayout(false);
        }



        #endregion


        private ReportViewer reportViewer1;
    }
}