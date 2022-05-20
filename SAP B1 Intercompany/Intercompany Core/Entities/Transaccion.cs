using System;
using System.ComponentModel.DataAnnotations;

namespace Intercompany_Core.Entities
{
    public class Transaccion
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public DateTime FechaSincronizacion { get; set; }
        public int TipoTransaccion { get; set; }
        public string TipodCRUD { get; set; }
        public int IdOrigen { get; set; }
        public int IdDestino { get; set; }
        public char Sincronizado { get; set; }
        public string ErrorDesc { get; set; }
        public string JSON { get; set; }
        public int IdObjeto { get; set; }
    }
}
