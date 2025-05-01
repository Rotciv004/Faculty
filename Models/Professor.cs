using System.ComponentModel.DataAnnotations;

namespace Facultate.Models
{
    public class Professor
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
