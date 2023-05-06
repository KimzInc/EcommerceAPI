using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Dtos
{
    public class CommandCreateDto
    {
        
        //we do not need an id here because the database will create it
        [Required]
        public string? HowTo { get; set; }
        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }

    }
}