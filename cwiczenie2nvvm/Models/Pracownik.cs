using System;
using System.Collections.Generic;
using System.Text;

namespace cwiczenie2nvvm.Models
{
    public class Pracownik
    {
        public string imie { get; set; } = string.Empty;
        public string nazwisko { get; set; } = string.Empty;
        public float wynagrodzenie { get; set; }
        public DateTime dataZatrudnienia { get; set; } = DateTime.Now;
        public DateTime? dataKoncaZatrudnienia { get; set; } = null;
    }
}
