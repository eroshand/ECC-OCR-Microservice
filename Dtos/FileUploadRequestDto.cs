using System.ComponentModel.DataAnnotations;

namespace ECC_OCR_Microservice.Dtos
{
    public class FileUploadRequestDto
    {
        [Required]
        public IFormFile File { get; set; }
    }
}
