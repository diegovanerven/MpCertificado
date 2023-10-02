using Microsoft.AspNetCore.Mvc;

namespace MpCertificado.Services.CertificadoAnuncioService
{
    public interface ICertificadoAnuncioService
    {
        Task<List<CertificadoAnuncio>> GetAllCertificadoAnuncio();

        Task<CertificadoAnuncio?> GetSingleCertificadoAnuncio(int idCertificadoA);

        Task<List<CertificadoAnuncio>> AddCertificadoAnuncio(CertificadoAnuncio certificadoA);

        Task<List<CertificadoAnuncio>?> UpdateCertificadoAnuncio(int id, CertificadoAnuncio request);

        Task<List<CertificadoAnuncio>?> DeleteCertificadoAnuncio(int id);



    }
}
