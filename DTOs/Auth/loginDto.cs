using System.ComponentModel.DataAnnotations;

namespace Mini_Task_Manager_API.DTOs.Auth
{
    public class LoginDto
    {
        [Required]
        public string username { get; set; } = string.Empty;

        [Required] 
        public string password { get; set; } = string.Empty;
    }
}
