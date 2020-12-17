using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Ordenes
    {
        public int id { get; set; }
        public string fec_rec { get; set; }
        public Cliente id_cliente { get; set; }
        public string proveedor { get; set; }
        public string contenido { get; set; }
        public string peso { get; set; }
        public string ubicacion { get; set; }
        public string regimen { get; set; }
        public string fec_num { get; set; }
        public string fec_entrega { get; set; }
        public double valor_num { get; set; }
    }
}