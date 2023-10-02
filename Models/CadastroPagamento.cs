using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Pesquisar como carregar chave estrangeira de cpf e cnpj

namespace MpCertificado.Models
{
    public class CadastroPagamento
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdCartao { get; set; }
        public string NomeTitular { get; set; } = string.Empty;
        public int NumeroCartao { get; set; }
        public int ValidadeCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public string EnderecoFaturamento { get; set; } = string.Empty;
        public string BancoEmissor { get; set; } = string.Empty;
        public string BandeiraCartao { get; set; } = string.Empty;
        public int CpfTitular { get; set; }
        public int TelefoneTitular { get; set; }

    }
}
