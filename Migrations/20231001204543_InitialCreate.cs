using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MpCertificado.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificadoAnuncios",
                columns: table => new
                {
                    IdCertificadoA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDeDispositivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFabricante = table.Column<int>(type: "int", nullable: false),
                    TempoDeValidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDeEmissao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificadoAnuncios", x => x.IdCertificadoA);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificadoAnuncios");
        }
    }
}
