using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace parcialprogra.Models
{
    [Table("remesas")]
    public class Transaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("remitente")]
        public string? Remitente { get; set; }

        [Column("destinatario")]
        public string? Destinatario { get; set; }

        [Column("pais_origen")]
        public string? PaisOrigen { get; set; }

        [Column("pais_destino")]
        public string? PaisDestino { get; set; }

        [Column("monto_enviado")]
        public decimal MontoEnviado { get; set; }

        [Column("moneda")]
        public string? Moneda { get; set; } // USD o BTC

        [Column("tasa_cambio_id")]
        public string? TasaCambioId { get; set; }

        [Column("monto_final")]
        public decimal MontoFinal { get; set; }

        [Column("estado")]
        public string? Estado { get; set; }

        [Column("fecha_transaccion")]
        public DateTime FechaTransaccion { get; set; } = DateTime.UtcNow;
    }
}
