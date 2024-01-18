using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPretragaIB220069 : Form
    {
        private List<dtoStudentPredmet> dtoStudentiPredmeti = new List<dtoStudentPredmet>();
        private KonekcijaNaBazu db = new KonekcijaNaBazu();
        List<Student> studenti = new List<Student>();
        
        private string Sadrzaj { get; set; }
        public frmPretragaIB220069()
        {
            InitializeComponent();
            dgvListaStudenata.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220069_Load(object sender, EventArgs e)
        {
            studenti = db.Studenti.ToList();
            cmbStudenti.DataSource= studenti;
            
            
           
        }

        private void UcitajStudente()
        {
            
            

            int filterOcjena = int.Parse(cmbOcjene.SelectedItem.ToString());

            List<StudentiPredmeti> listaStudentPredmeti = new List<StudentiPredmeti>();
            listaStudentPredmeti = db.StudentiPredmeti.Include(sp => sp.Predmet).Include(sp => sp.Student).ToList();

            //List<Predmet> predmeti = new List<Predmet>();
            //predmeti = db.Predmeti.ToList();


            int brojac = 0;
            foreach (var p in listaStudentPredmeti)
            {
                dtoStudentiPredmeti.Add(new dtoStudentPredmet()
                {
                    Rb = 0,
                    DatumPolaganja = p.DatumPolaganja,
                    Ocjena = p.Ocjena,
                    ImePrezime = $"{p.Student.Ime} {p.Student.Prezime}",
                    Predmet = p.Predmet.Naziv,
                    student = p.Student,
                    predmet = p.Predmet,
                });
            }

            dtoStudentiPredmeti = dtoStudentiPredmeti.Where(p => p.Ocjena >= filterOcjena).ToList();
            foreach (var p in dtoStudentiPredmeti)
            {
                p.Rb = ++brojac;
            }

            Text = $"Ukupno zapisa -> {dtoStudentiPredmeti.Count}";
            dgvListaStudenata.DataSource = dtoStudentiPredmeti;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        public class dtoStudentPredmet
        {
            public int Rb { get; set; }
            public string Predmet { get; set; }
            public Predmet predmet { get; set; }
            public Student student { get; set; }
            public string ImePrezime { get; set; }
            public DateTime DatumPolaganja { get; set; }
            public int Ocjena { get; set; }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var forma = new frmIzvjestajIB220069(dtoStudentiPredmeti);
            forma.ShowDialog();
            
        }

        private void dgvListaStudenata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudentPredmet = dgvListaStudenata.SelectedRows[0].DataBoundItem as dtoStudentPredmet;
            if (dgvListaStudenata.CurrentCell is DataGridViewButtonCell)
            {
                var forma = new frmStudentSeminarskiIB220069(odabraniStudentPredmet);
                forma.ShowDialog();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPodatkeLog())
            {
                var brojOcjena = int.Parse(txtBrojOcjena.Text);

                var polozeniPredmet = new dtoDodavanje()
                {
                    brojDodavanja = brojOcjena,
                    student = cmbStudenti.SelectedItem as Student
                };

                Thread t1 = new Thread(() => DodajStudenta(polozeniPredmet));
                t1.Start();
            }
        }

        private void DodajStudenta(dtoDodavanje dtoDodavanje)
        {
            var rnd = new Random();
           
            for(int i=0;i<dtoDodavanje.brojDodavanja;i++)
            {
                var randomP = rnd.Next(1, 4);
               var obj = new StudentiPredmeti()
                {
                    DatumPolaganja = DateTime.Now,
                    Ocjena = rnd.Next(6, 10),
                    PredmetId=randomP,
                    Student=dtoDodavanje.student,
                    StudentId=dtoDodavanje.student.Id,
                    Predmet = db.Predmeti.ToList()[randomP]
                };
                Thread.Sleep(500);
                db.StudentiPredmeti.Add(obj);
                db.SaveChanges();
                BeginInvoke(IspisiSadrzaj);
                Sadrzaj += $"Za {dtoDodavanje.student.ToString()} dodat polozeni - > {obj.Predmet.Naziv} ({obj.Ocjena})\n";
            }
        }

        private void IspisiSadrzaj()
        {
            rtbInfo.Text = Sadrzaj;
            rtbInfo.SelectionStart = rtbInfo.TextLength;
            rtbInfo.ScrollToCaret();
        }

        public class dtoDodavanje
        {
            public Student student { get; set; }
            

            public int brojDodavanja { get; set; }
        }

        private bool ValidirajPodatkeLog()
        {
            return Validator.ValidirajKontrolu(txtBrojOcjena, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbStudenti, errorProvider1, Poruke.ObaveznaVrijednost);
        }
    }
}

