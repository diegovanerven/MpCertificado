using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MpCertificado.Services.CertificadoAnuncioService;
using System.Drawing;
using System.Threading.Tasks;

namespace MpCertificado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //Guia de Referência
    //CertificadoAnuncio == nome classe Model
    //certificadoAnuncios == Objeto lista
    //certificadoA == referência a objeto especifico
    public class CertificadoAnuncioController : ControllerBase
    {
        private readonly ICertificadoAnuncioService _certificadoService;

        //Metodo construtor
        public CertificadoAnuncioController(ICertificadoAnuncioService CertificadoService)
        {
            _certificadoService = CertificadoService;
        }



        // Criar uma lista de todos os certificados cadastrados.
        // usa objeto lista do codigo anterior

        [HttpGet]
        public async Task<ActionResult<List<CertificadoAnuncio>>> GetAllCertificadoAnuncio()
        { 
            return await _certificadoService.GetAllCertificadoAnuncio();
        }

        // Busca Item especifico por Id
        [HttpGet("{idCertificadoA}")]
        public async Task<ActionResult<CertificadoAnuncio>> GetSingleCertificadoAnuncio(int idCertificadoA)
        {
            var result = await _certificadoService.GetSingleCertificadoAnuncio(idCertificadoA);
            if (result is null)
                return NotFound("Desculpe, Certificado não cadastrado");

            return Ok(result);
        }

        //Adiciona novo Certificado 
        [HttpPost]
        public async Task<ActionResult<List<CertificadoAnuncio>>> AddCertificadoAnuncio (CertificadoAnuncio certificadoA)
        {
            //acessar service adicionar 
            var result = await _certificadoService.AddCertificadoAnuncio(certificadoA);
            return Ok(result);

        }

        //Atualiza item Certificado
        [HttpPut("{idCertificadoA}")]
        public async Task<ActionResult<List<CertificadoAnuncio>>> UpdateCertificadoAnuncio(int id, CertificadoAnuncio request)
        {
            var result = await _certificadoService.UpdateCertificadoAnuncio(id, request);
            if (result is null)
                return NotFound("Desculpe, Certificado não cadastrado");

            return Ok(result);
        }

        [HttpDelete("{idCertificadoA}")]
        public async Task<ActionResult<List<CertificadoAnuncio>>> DeleteCertificadoAnuncio(int id)
        {
            //acessar service e deletar
            var result = await _certificadoService.DeleteCertificadoAnuncio(id);
            if (result is null)
                return NotFound("Desculpe, Certificado não cadastrado");

            return Ok(result);
        }


    }
}
