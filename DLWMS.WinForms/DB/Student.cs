﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        
        public virtual List<PredmetiSeminarski> predmetiSeminarski { get; set; } = new List<PredmetiSeminarski>();
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
