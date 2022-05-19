using System.ComponentModel.DataAnnotations;

namespace ECC_OCR_Microservice.Dtos
{
    public class FileUploadRequestDto
    {
        [Required]
        public string DataBase64 { get; set; }
        
        [Required]
        public string FileName { get; set; }
    }
}
