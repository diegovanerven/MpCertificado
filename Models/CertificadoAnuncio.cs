﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MpCertificado.Models
{
    public class CertificadoAnuncio
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdCertificadoA { get; set; }
        public string TipoDeCliente { get; set; } = string.Empty;
        public string TipoDeDispositivo { get; set; } = string.Empty;
        public string Fabricante { get; set; } = string.Empty;
        public int IdFabricante { get; set; }
        public string TempoDeValidade { get; set; } = string.Empty;
        public string TipoDeEmissao { get; set; } = string.Empty;
        public float Valor { get; set; }


    }
}
