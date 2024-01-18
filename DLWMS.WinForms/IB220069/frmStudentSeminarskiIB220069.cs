using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DLWMS.WinForms.IB220069.frmPretragaIB220069;

namespace DLWMS.WinForms.IB220069
{
    public partial class frmStudentSeminarskiIB220069 : Form
    {
        private dtoStudentPredmet odabraniStudentPredmet;
        private KonekcijaNaBazu db = new KonekcijaNaBazu();
        int index = 0;
        List<PredmetiSeminarski> listaSeminarski = new List<PredmetiSeminarski>();
        public frmStudentSeminarskiIB220069()
        {
            InitializeComponent();
        }

        public frmStudentSeminarskiIB220069(dtoStudentPredmet odabraniStudentPredmet) : this()
        {
            this.odabraniStudentPredmet = odabraniStudentPredmet;
        }

        private void pcbNoviSlika_DoubleClick(object sender, EventArgs e)
        {
            if (ofdSlikaSeminarskog.ShowDialog() == DialogResult.OK)
            {
                pcbNoviSlika.Image = Image.FromFile(ofdSlikaSeminarskog.FileName);
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (ValidirajPodatke())
            {
                var obj = new PredmetiSeminarski()
                {
                    DatumDodavanja = DateTime.Now,
                    Opis = txtOpis.Text,
                    Slika = ImageHelper.FromImageToByte(pcbNoviSlika.Image),
                    PredmetId = odabraniStudentPredmet.predmet.Id,
                    StudentId = odabraniStudentPredmet.student.Id

                };
                db.PredmetiSeminarski.Add(obj);
                db.SaveChanges();
            }
        }

        private bool ValidirajPodatke()
        {
            return Validator.ValidirajKontrolu(pcbNoviSlika, errSeminarski, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtOpis, errSeminarski, Poruke.ObaveznaVrijednost);
        }

        private void frmStudentSeminarskiIB220069_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = odabraniStudentPredmet.ImePrezime;
            lblPredmet.Text = odabraniStudentPredmet.Predmet;


            listaSeminarski = db.PredmetiSeminarski.Where(sp => sp.StudentId == odabraniStudentPredmet.student.Id && sp.PredmetId == odabraniStudentPredmet.predmet.Id).ToList();
            if (listaSeminarski.Count == 0)
            {
                lblStranicaBroj.Text = $" Stranica {0} \\ {listaSeminarski.Count}";
            }

            else
            {
                VratiStranicu(index);

            }
        }

        private void VratiStranicu(int v)
        {
            pcbSlikaSeminarskog.Image = ImageHelper.FromByteToImage(listaSeminarski[v].Slika);
            lblStranicaBroj.Text = $" Stranica {v + 1} \\ {listaSeminarski.Count}";
            lblOpis.Text = listaSeminarski[v].Opis.ToString();
            lblDatum.Text = listaSeminarski[v].DatumDodavanja.ToString();
        }

        private void btnDesnoSlika_Click(object sender, EventArgs e)
        {
            int temp = index;
            if (++temp < listaSeminarski.Count)
            {
                index = temp;
                VratiStranicu(index);
            }
        }

        private void btnLijevoSlika_Click(object sender, EventArgs e)
        {
            int temp = index;
            if (--temp >= 0)
            {
                index = temp;
                VratiStranicu(index);
            }
        }
    }
}
