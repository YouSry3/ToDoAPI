using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TodoApplicationAPI.Models;

namespace ToDoApi.Models
{
    public class User
    {
        public int Id { get; set; } // ID فريد للمستخدم

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
        public string PasswordHash { get; set; } = string.Empty; 

        public ICollection<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
    }
}
