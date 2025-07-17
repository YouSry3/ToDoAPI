namespace ToDoApi.Models
{
    public class User
    {
        public int Id { get; set; } // ID فريد للمستخدم
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty; // تخزين كلمة السر بعد التشفير

        // العلاقة: المستخدم لديه مجموعة مهام
        public ICollection<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
    }
}
