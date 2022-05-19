using ECC_OCR_Microservice.Dtos;
using ECC_OCR_Microservice.Model.PurchaseSale;
using ECC_OCR_Microservice.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ECC_OCR_Microservice.Controllers
{
    [Route("api/purchasesale")]
    public class PurchaseSaleController: Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPurchaseSaleService _purchaseSaleService;

        public PurchaseSaleController(ILogger<WeatherForecastController> logger, IPurchaseSaleService purchaseSaleService)
        {
            _purchaseSaleService = purchaseSaleService;
            _logger = logger;
        }

        [HttpPost]
        [Route("readfile")]
        public async Task<IActionResult> ReadPdfFileAsync(FileUploadRequestDto fileUploadRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            JsonSerializerOptions options = new()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            return Ok(_purchaseSaleService.ReadFileAsync(fileUploadRequestDto));
        }
    }
}
