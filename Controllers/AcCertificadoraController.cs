using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MpCertificado.Services.CertificadoAnuncioService;
using System.Drawing;
using System.Threading.Tasks;

namespace MpCertificado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcCertificadoraController : Controller
    {
       private readonly _acCertificadora;
    }
}
