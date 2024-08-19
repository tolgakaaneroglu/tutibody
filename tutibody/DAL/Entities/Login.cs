using System.ComponentModel.DataAnnotations;

namespace tutibody.DAL.Entities
{
    public class Login
    {
        [Key]
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
