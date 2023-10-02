using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Descobrir como ocorrera a compra, adicionar futuramente informações para isso

namespace MpCertificado.Models
{
    public class AcCertificadora
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdCertificadora { get; set; }
        public string NomeCertificadora { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public int NumeroInmetro { get; set; } 
    }
}
