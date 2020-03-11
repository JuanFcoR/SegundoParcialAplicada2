using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAplicada2.Models
{
    public class LlamadaDetalle
    {
        [Key]
        public int LlamadaDetalleId { get; set; }
        public string Problema { get; set; }
        public string Solucion { get; set; }

        public LlamadaDetalle(int llamadaDetalleId, string problema, string solucion)
        {
            LlamadaDetalleId = llamadaDetalleId;
            Problema = problema;
            Solucion = solucion;
        }


    }
}
