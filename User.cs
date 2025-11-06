using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "用户名是必填项")]
        public string Username { get; set; }

        [Required(ErrorMessage = "密码是必填项")]
        public string Password { get; set; }

        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}