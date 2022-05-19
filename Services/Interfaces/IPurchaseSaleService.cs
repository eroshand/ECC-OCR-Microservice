using ECC_OCR_Microservice.Dtos;
using ECC_OCR_Microservice.Model.PurchaseSale;

namespace ECC_OCR_Microservice.Services.Interfaces
{
    public interface IPurchaseSaleService
    {
        public Task<PurchaseSaleModel> ReadFileAsync(FileUploadRequestDto fileUploadRequestDto);
    }
}
