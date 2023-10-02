namespace MpCertificado.Services.CertificadoAnuncioService
{
    public class CertificadoAnuncioService : ICertificadoAnuncioService
    {
        

        private readonly DataContext _context;

        public CertificadoAnuncioService(DataContext context) 
        {
            _context = context;
         
        }



        //Adicionar novo certificado
        public async Task<List<CertificadoAnuncio>> AddCertificadoAnuncio(CertificadoAnuncio certificadoA)
        {
           _context.CertificadoAnuncios.Add(certificadoA);
            await _context.SaveChangesAsync();

            return await _context.CertificadoAnuncios.ToListAsync();
        }


        // service delete certificado
        public async Task<List<CertificadoAnuncio>?> DeleteCertificadoAnuncio(int idCertificadoA)
        {
            var certificadoA = await _context.CertificadoAnuncios.FindAsync(idCertificadoA);
            if (certificadoA is null)
                return null;

           _context.CertificadoAnuncios.Remove(certificadoA);
            await _context.SaveChangesAsync();

            return await _context.CertificadoAnuncios.ToListAsync();
        }

        //Mostrar lista de certificados
        public async Task<List<CertificadoAnuncio>> GetAllCertificadoAnuncio()
        {   
            
            // criei certificados aqui, estou meio na duvida. rever se esta correto
            var certificados = await _context.CertificadoAnuncios.ToListAsync();
            return certificados;
        }
        
        //Localizar um certificado
        public async Task<CertificadoAnuncio?> GetSingleCertificadoAnuncio(int idCertificadoA)
        {
            //Nota: x.IdCetificadoA refere-se a variável da classe( inicia com letra maiuscula), idCetificadoA variavel criada para pesquisa (inicia com minuscula)
            var certificadoA = await _context.CertificadoAnuncios.FindAsync(idCertificadoA);
            if (certificadoA is null)
                return null;

            return certificadoA;
        }
        
        //Atualizar um certificado
        public async Task<List<CertificadoAnuncio>?> UpdateCertificadoAnuncio(int idCertificadoA, CertificadoAnuncio request)
        {
            //Buscar Objeto por id no database
            var certificadoA = await _context.CertificadoAnuncios.FindAsync(idCertificadoA);
            if (certificadoA is null)
                return null;

            //Atualizar itens do cadastro solicitado
            //*Nota correção: tentar evitar que ele solicite o id na hora de completar os requests. 
            // Dessa forma todos os itens devem ser atualizados, para alterar apenas um criar um put especifico.
            certificadoA.TipoDeCliente = request.TipoDeCliente;
            certificadoA.TipoDeDispositivo = request.TipoDeDispositivo;
            certificadoA.TipoDeEmissao = request.TipoDeEmissao;
            certificadoA.TempoDeValidade = request.TempoDeValidade;
            certificadoA.Fabricante = request.Fabricante;
            certificadoA.Valor = request.Valor;
            certificadoA.IdFabricante = request.IdFabricante;

            //Salvar Mudanças
            await _context.SaveChangesAsync();

            return await _context.CertificadoAnuncios.ToListAsync();
        }
    }
}
