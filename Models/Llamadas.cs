using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAplicada2.Models
{
    public class Llamadas
    {
        [Key]
        public int LlamadaId { get; set; }
        public string Descripcion { get; set; }
        public List<LlamadaDetalle> Detalle;

        public Llamadas()
        {
            LlamadaId = 0;
            Descripcion = string.Empty;
            Detalle = new List<LlamadaDetalle>();
        }
    }
}
