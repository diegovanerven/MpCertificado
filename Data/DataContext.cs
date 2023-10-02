

namespace MpCertificado.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) 
        {
            
        }
        
        // Aqui conecta ao banco de dados. usando SQL Express. instalado a parte, baixado do site microsoft
        // Cria a database no servidor
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=certificadodb;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        //Cria table no database
        //nome tabela no plural
        public DbSet<CertificadoAnuncio> CertificadoAnuncios { get; set; }
    }
}
