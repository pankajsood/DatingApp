using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}