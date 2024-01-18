using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB220069
{
    public partial class frmIzvjestajIB220069 : Form
    {
        private List<frmPretragaIB220069.dtoStudentPredmet> dtoStudentiPredmeti;

        public frmIzvjestajIB220069()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB220069(List<frmPretragaIB220069.dtoStudentPredmet> dtoStudentiPredmeti) : this()
        {
            this.dtoStudentiPredmeti = dtoStudentiPredmeti;
        }

        private void frmIzvjestajIB220069_Load(object sender, EventArgs e)
        {
            var pOcjena = ProsjecnaOcjena();
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("brojPolozenih", dtoStudentiPredmeti.Count.ToString()));
            parametri.Add(new ReportParameter("prosjecnaOcjena", pOcjena.ToString()));

            var polozeni = new dsStudentiPredmeti.StudentiPredmetiDataTable();
            for (int i = 0; i < dtoStudentiPredmeti.Count; i++)
            {
                var red = polozeni.NewStudentiPredmetiRow();
                red.Rb = dtoStudentiPredmeti[i].Rb.ToString();
                red.ImePrezime = dtoStudentiPredmeti[i].ImePrezime.ToString();
                red.Predmet = dtoStudentiPredmeti[i].Predmet;
                red.Datum = dtoStudentiPredmeti[i].DatumPolaganja.ToString();
                red.Ocjena = dtoStudentiPredmeti[i].Ocjena.ToString();
                polozeni.AddStudentiPredmetiRow(red);
            }

            var rds = new ReportDataSource();
            rds.Value = polozeni;
            rds.Name = "dsStudentiPredmeti";

            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private object ProsjecnaOcjena()
        {
            float zbir = 0.0f;
            for (int i = 0; i < dtoStudentiPredmeti.Count; i++)
            {
                zbir += dtoStudentiPredmeti[i].Ocjena;
            }
            return zbir / dtoStudentiPredmeti.Count;
        }
    }
}

