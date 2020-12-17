using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Facturas
    {
        public int id { get; set; }
        public string archivo { get; set; }
        public string factura { get; set; }
        public string fec_fac { get; set; }
        public string fec_canc { get; set; }
        public string dua { get; set; }
        public double cif { get; set; }
        public double tc { get; set; }
        public double adval { get; set; }
        public double igv { get; set; }
        public double ipm { get; set; }
        public double reintegro { get; set; }
        public double total_liq { get; set; }
        public double gasto_ope { get; set; }
        public double gasto_admin { get; set; }
        public double sup_cont { get; set; }
        public double comision { get; set; }
        public double igv_2 { get; set; }
        public double total_neto { get; set; }
    }
}