using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Ordenes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name="Fecha de recepción")]
        public string fec_rec { get; set; }
        [Display(Name="Código de cliente")]
        public Cliente id_cliente { get; set; }
        [Display(Name="Proveedor")]
        public string proveedor { get; set; }
        [Display(Name="Contenido")]
        public string contenido { get; set; }
        [Display(Name="Peso")]
        public string peso { get; set; }
        [Display(Name="Ubicación")]
        public string ubicacion { get; set; }
        [Display(Name="Régimen")]
        public string regimen { get; set; }
        [Display(Name="Fec. Numeración")]
        public string fec_num { get; set; }
        [Display(Name="Fec. Entrega")]
        public string fec_entrega { get; set; }
        [Display(Name="T/C. - S/")]
        public double valor_num { get; set; }
    }
}